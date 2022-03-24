#!/usr/bin/env sh

set -e

script="$0"
DIR="$(dirname $script)"

capabilities=$(capsh --print | grep -e "Current: .*ipc_lock" | sed s/\n// | sed s/\ //)
ipc_error="IPC_LOCK capability is not enabled. If you are running a docker container, add the capability using the '--cap-add' option."

if [ -z "$capabilities" ]; then
    echo "$ipc_error"
    exit 2
fi

if ! pgrep -x "dbus-daemon" > /dev/null
then
    export DBUS_SESSION_BUS_ADDRESS=$(dbus-daemon --session --fork --print-address)
else
    echo "dbus-daemon already running"
fi

dbus-run-session -- echo "$KEYRING_PASSWORD" | gnome-keyring-daemon --daemonize --components=secrets --unlock && "$@"
