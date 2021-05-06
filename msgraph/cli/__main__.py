# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
# --------------------------------------------------------------------------

import sys
import signal
from os import path, devnull, dup2, open, O_WRONLY

from colorama import init, Fore

from msgraph.cli.core import get_default_cli
from msgraph.cli.core.constants import DEFAULT_PROFILE, PROFILE_LOCATION
from msgraph.cli.core.profile import ProfileProvider

mg_cli = get_default_cli()
init(autoreset=True)


# Check if a profile exists, if not create one
def create_profile_if_none_exists():
    has_profile = path.exists(PROFILE_LOCATION)

    if not has_profile:
        profile_provider = ProfileProvider()

        profile_provider.write_profile(DEFAULT_PROFILE,
                                       error_msg='An error occured while creating your profile')
        # Let the user know we have created a default profile for them
        show_default_profile_msg()


def show_default_profile_msg():
    msg = f'''
You're using the default profile

CLOUD: {DEFAULT_PROFILE['cloud']}
VERSION: {DEFAULT_PROFILE['version']}

Run mg profile -h for profile commands
        '''
    print(Fore.YELLOW + msg)


def cli_main(cli, args):
    create_profile_if_none_exists()
    return cli.invoke(args)


try:
    exit_code = cli_main(mg_cli, sys.argv[1:])
    sys.exit(exit_code)
except KeyboardInterrupt:
    sys.exit(1)
