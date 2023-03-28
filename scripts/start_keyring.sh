#!/usr/bin/env sh

SESSION_FILE=~/.user-dbus-session

# Check if session file is orphaned
if [ -f "$SESSION_FILE" ]; then
  # if the file exists and dbus isn't running, remove it
  if ! pgrep -u $(whoami) -f "dbus-daemon" > /dev/null
  then
    rm "$SESSION_FILE"
  fi
fi

# test for an existing bus daemon, just to be safe
if [ ! -f "$SESSION_FILE" ]; then
  if test -z "$DBUS_SESSION_BUS_ADDRESS" ; then
    # if not found, launch a new one
    echo $(dbus-launch --sh-syntax) > $SESSION_FILE
  fi
fi

# Get DBus process details
. "$SESSION_FILE"

if [ -n "$DBUS_SESSION_BUS_ADDRESS" ]; then
  echo "D-Bus daemon address is: $DBUS_SESSION_BUS_ADDRESS"
  if ! pgrep -u $(whoami) -f "gnome-keyring-daemon" > /dev/null
  then
    export KEYRING_PASSWORD=any-password
    dbus-run-session -- echo -n "$KEYRING_PASSWORD" | gnome-keyring-daemon --daemonize --components=secrets --unlock
  fi
else
  echo "D-Bus daemon is not running"
  exit 1
fi
