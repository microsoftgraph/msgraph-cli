# --------------------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# --------------------------------------------------------------------------------------------

import os
from knack import CLI

from msgraph.cli.core.commands._util import _load_module_command_loader, _load_extension_command_loader
from msgraph.cli.core.invocation import GraphCliCommandInvoker
from msgraph.cli.core.commands import GraphCommandGroup, GraphCliCommand
from msgraph.cli.core.commands._util import get_arg_list
from msgraph.cli.core.commands.client_factory import resolve_client_arg_name
from msgraph.cli.core.commands.parameters import GraphArgumentContext
from msgraph.cli.core.help._help import GraphCliHelp
from msgraph.cli.core.constants import EXCLUDED_PARAMS
from msgraph.cli.core.command_loaders import MainCommandsLoader, ExtensionCommandsLoader
from msgraph.cli.core.mglogging import MgCliLogging

__version__ = "0.1.0"


class MgCLI(CLI):
    def __init__(self, **kwargs):
        super().__init__(**kwargs)

    def refresh_request_id(self):
        """Assign a new random GUID as client-request-id
        The method must be invoked before each command execution in order to ensure
        unique client-side request ID is generated.
        """
        import uuid
        self.data['headers'] = {
            'client-request-id': str(uuid.uuid1()),
        }

    def get_cli_version(self):
        return __version__


# This is the entry point into the Knack CLI framework.
def get_default_cli():
    return MgCLI(cli_name='mg',
                 commands_loader_cls=MainCommandsLoader,
                 invocation_cls=GraphCliCommandInvoker,
                 help_cls=GraphCliHelp,
                 logging_cls=MgCliLogging)


# Generated extensions expect the CommandLoader class to have the name AzCommandLoader
AzCommandsLoader = ExtensionCommandsLoader
