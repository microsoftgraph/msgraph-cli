#!/usr/bin/env sh

# Check for required tools first
if ! which "dbus-daemon" > /dev/null ; then
  echo "'dbus-daemon' not found. Please install dbus and libsecret."
else
  if ! which "gnome-keyring-daemon" > /dev/null ; then
    echo "'gnome-keyring-daemon' not found. Please install gnome-keyring."
  else
    SESSION_FILE=~/.user-dbus-session

    # Check if session file is orphaned
    if [ -f "$SESSION_FILE" ]; then
      # if the file exists and dbus isn't running, remove it
      if ! pgrep -u $(whoami) -f "dbus-daemon" > /dev/null ; then
        rm "$SESSION_FILE"
      fi
    fi

    # test for an existing bus daemon
    if [ ! -f "$SESSION_FILE" ]; then
      # if not found, launch a new one
      echo "Starting DBus session daemon."
      echo  "export DBUS_SESSION_BUS_ADDRESS=$(dbus-daemon --session --fork --print-address)" > $SESSION_FILE
    fi

    if ! pgrep -u $(whoami) -f "dbus-daemon" > /dev/null ; then
      echo "Error: DBus session daemon failed to start!"
    else
      # Load DBus session address
      . "$SESSION_FILE"

      if [ -n "$DBUS_SESSION_BUS_ADDRESS" ]; then
        echo "D-Bus daemon address is: $DBUS_SESSION_BUS_ADDRESS"
        if ! pgrep -u $(whoami) -f "gnome-keyring-daemon" > /dev/null ; then
          export KEYRING_PASSWORD=any-password
          echo -n "$KEYRING_PASSWORD" | gnome-keyring-daemon --daemonize --components=secrets --unlock
        fi
      else
        echo "Error: D-Bus daemon is not running."
      fi
    fi
  fi
fi
