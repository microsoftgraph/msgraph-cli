#!/usr/bin/env sh

set -e

script="$0"
DIR="$(dirname $script)"

if ! pgrep -x "dbus-daemon" > /dev/null
then
    export DBUS_SESSION_BUS_ADDRESS=$(dbus-daemon --session --fork --print-address)
else
    echo "dbus-daemon already running"
fi

dbus-run-session -- echo "$KEYRING_PASSWORD" | gnome-keyring-daemon --daemonize --components=secrets --unlock && "$@"
