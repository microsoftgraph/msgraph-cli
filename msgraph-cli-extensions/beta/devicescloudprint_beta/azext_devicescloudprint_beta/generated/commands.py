# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------
# pylint: disable=too-many-statements
# pylint: disable=too-many-locals
# pylint: disable=bad-continuation
# pylint: disable=line-too-long

from msgraph.cli.core.commands import CliCommandType
from azext_devicescloudprint_beta.generated._client_factory import (
    cf_print_print,
    cf_print,
    cf_print_printer,
    cf_print_printer_task_trigger,
    cf_print_printer_share,
    cf_print_printer_share_printer,
    cf_print_report,
    cf_print_service,
    cf_print_share,
    cf_print_share_printer,
    cf_print_task_definition,
    cf_print_task_definition_task,
)


devicescloudprint_beta_print_print = CliCommandType(
    operations_tmpl='azext_devicescloudprint_beta.vendored_sdks.devicescloudprint.operations._print_print_operations#PrintPrintOperations.{}',
    client_factory=cf_print_print,
)


devicescloudprint_beta_print = CliCommandType(
    operations_tmpl=(
        'azext_devicescloudprint_beta.vendored_sdks.devicescloudprint.operations._print_operations#PrintOperations.{}'
    ),
    client_factory=cf_print,
)


devicescloudprint_beta_print_printer = CliCommandType(
    operations_tmpl='azext_devicescloudprint_beta.vendored_sdks.devicescloudprint.operations._print_printers_operations#PrintPrintersOperations.{}',
    client_factory=cf_print_printer,
)


devicescloudprint_beta_print_printer_task_trigger = CliCommandType(
    operations_tmpl='azext_devicescloudprint_beta.vendored_sdks.devicescloudprint.operations._print_printers_task_triggers_operations#PrintPrintersTaskTriggersOperations.{}',
    client_factory=cf_print_printer_task_trigger,
)


devicescloudprint_beta_print_printer_share = CliCommandType(
    operations_tmpl='azext_devicescloudprint_beta.vendored_sdks.devicescloudprint.operations._print_printer_shares_operations#PrintPrinterSharesOperations.{}',
    client_factory=cf_print_printer_share,
)


devicescloudprint_beta_print_printer_share_printer = CliCommandType(
    operations_tmpl='azext_devicescloudprint_beta.vendored_sdks.devicescloudprint.operations._print_printer_shares_printer_operations#PrintPrinterSharesPrinterOperations.{}',
    client_factory=cf_print_printer_share_printer,
)


devicescloudprint_beta_print_report = CliCommandType(
    operations_tmpl='azext_devicescloudprint_beta.vendored_sdks.devicescloudprint.operations._print_reports_operations#PrintReportsOperations.{}',
    client_factory=cf_print_report,
)


devicescloudprint_beta_print_service = CliCommandType(
    operations_tmpl='azext_devicescloudprint_beta.vendored_sdks.devicescloudprint.operations._print_services_operations#PrintServicesOperations.{}',
    client_factory=cf_print_service,
)


devicescloudprint_beta_print_share = CliCommandType(
    operations_tmpl='azext_devicescloudprint_beta.vendored_sdks.devicescloudprint.operations._print_shares_operations#PrintSharesOperations.{}',
    client_factory=cf_print_share,
)


devicescloudprint_beta_print_share_printer = CliCommandType(
    operations_tmpl='azext_devicescloudprint_beta.vendored_sdks.devicescloudprint.operations._print_shares_printer_operations#PrintSharesPrinterOperations.{}',
    client_factory=cf_print_share_printer,
)


devicescloudprint_beta_print_task_definition = CliCommandType(
    operations_tmpl='azext_devicescloudprint_beta.vendored_sdks.devicescloudprint.operations._print_task_definitions_operations#PrintTaskDefinitionsOperations.{}',
    client_factory=cf_print_task_definition,
)


devicescloudprint_beta_print_task_definition_task = CliCommandType(
    operations_tmpl='azext_devicescloudprint_beta.vendored_sdks.devicescloudprint.operations._print_task_definitions_tasks_operations#PrintTaskDefinitionsTasksOperations.{}',
    client_factory=cf_print_task_definition_task,
)


def load_command_table(self, _):

    with self.command_group(
        'devicescloudprint print-print', devicescloudprint_beta_print_print, client_factory=cf_print_print
    ) as g:
        g.custom_command('show-print', 'devicescloudprint_print_print_show_print')
        g.custom_command('update-print', 'devicescloudprint_print_print_update_print')

    with self.command_group('devicescloudprint print', devicescloudprint_beta_print, client_factory=cf_print) as g:
        g.custom_command('create-connector', 'devicescloudprint_print_create_connector')
        g.custom_command('create-operation', 'devicescloudprint_print_create_operation')
        g.custom_command('create-printer', 'devicescloudprint_print_create_printer')
        g.custom_command('create-printer-share', 'devicescloudprint_print_create_printer_share')
        g.custom_command('create-report', 'devicescloudprint_print_create_report')
        g.custom_command('create-service', 'devicescloudprint_print_create_service')
        g.custom_command('create-share', 'devicescloudprint_print_create_share')
        g.custom_command('create-task-definition', 'devicescloudprint_print_create_task_definition')
        g.custom_command('delete-connector', 'devicescloudprint_print_delete_connector')
        g.custom_command('delete-operation', 'devicescloudprint_print_delete_operation')
        g.custom_command('delete-printer', 'devicescloudprint_print_delete_printer')
        g.custom_command('delete-printer-share', 'devicescloudprint_print_delete_printer_share')
        g.custom_command('delete-report', 'devicescloudprint_print_delete_report')
        g.custom_command('delete-service', 'devicescloudprint_print_delete_service')
        g.custom_command('delete-share', 'devicescloudprint_print_delete_share')
        g.custom_command('delete-task-definition', 'devicescloudprint_print_delete_task_definition')
        g.custom_command('list-connector', 'devicescloudprint_print_list_connector')
        g.custom_command('list-operation', 'devicescloudprint_print_list_operation')
        g.custom_command('list-printer', 'devicescloudprint_print_list_printer')
        g.custom_command('list-printer-share', 'devicescloudprint_print_list_printer_share')
        g.custom_command('list-report', 'devicescloudprint_print_list_report')
        g.custom_command('list-service', 'devicescloudprint_print_list_service')
        g.custom_command('list-share', 'devicescloudprint_print_list_share')
        g.custom_command('list-task-definition', 'devicescloudprint_print_list_task_definition')
        g.custom_command('show-connector', 'devicescloudprint_print_show_connector')
        g.custom_command('show-operation', 'devicescloudprint_print_show_operation')
        g.custom_command('show-printer', 'devicescloudprint_print_show_printer')
        g.custom_command('show-printer-share', 'devicescloudprint_print_show_printer_share')
        g.custom_command('show-report', 'devicescloudprint_print_show_report')
        g.custom_command('show-service', 'devicescloudprint_print_show_service')
        g.custom_command('show-share', 'devicescloudprint_print_show_share')
        g.custom_command('show-task-definition', 'devicescloudprint_print_show_task_definition')
        g.custom_command('update-connector', 'devicescloudprint_print_update_connector')
        g.custom_command('update-operation', 'devicescloudprint_print_update_operation')
        g.custom_command('update-printer', 'devicescloudprint_print_update_printer')
        g.custom_command('update-printer-share', 'devicescloudprint_print_update_printer_share')
        g.custom_command('update-report', 'devicescloudprint_print_update_report')
        g.custom_command('update-service', 'devicescloudprint_print_update_service')
        g.custom_command('update-share', 'devicescloudprint_print_update_share')
        g.custom_command('update-task-definition', 'devicescloudprint_print_update_task_definition')

    with self.command_group(
        'devicescloudprint print-printer', devicescloudprint_beta_print_printer, client_factory=cf_print_printer
    ) as g:
        g.custom_command('create', 'devicescloudprint_print_printer_create')
        g.custom_command('create-allowed-group', 'devicescloudprint_print_printer_create_allowed_group')
        g.custom_command('create-allowed-user', 'devicescloudprint_print_printer_create_allowed_user')
        g.custom_command('create-ref-connector', 'devicescloudprint_print_printer_create_ref_connector')
        g.custom_command('create-ref-share', 'devicescloudprint_print_printer_create_ref_share')
        g.custom_command('create-task-trigger', 'devicescloudprint_print_printer_create_task_trigger')
        g.custom_command('delete-allowed-group', 'devicescloudprint_print_printer_delete_allowed_group')
        g.custom_command('delete-allowed-user', 'devicescloudprint_print_printer_delete_allowed_user')
        g.custom_command('delete-ref-share', 'devicescloudprint_print_printer_delete_ref_share')
        g.custom_command('delete-task-trigger', 'devicescloudprint_print_printer_delete_task_trigger')
        g.custom_command('list-allowed-group', 'devicescloudprint_print_printer_list_allowed_group')
        g.custom_command('list-allowed-user', 'devicescloudprint_print_printer_list_allowed_user')
        g.custom_command('list-connector', 'devicescloudprint_print_printer_list_connector')
        g.custom_command('list-ref-connector', 'devicescloudprint_print_printer_list_ref_connector')
        g.custom_command('list-ref-share', 'devicescloudprint_print_printer_list_ref_share')
        g.custom_command('list-share', 'devicescloudprint_print_printer_list_share')
        g.custom_command('list-task-trigger', 'devicescloudprint_print_printer_list_task_trigger')
        g.custom_command('reset-default', 'devicescloudprint_print_printer_reset_default')
        g.custom_command('restore-factory-default', 'devicescloudprint_print_printer_restore_factory_default')
        g.custom_command('set-ref-share', 'devicescloudprint_print_printer_set_ref_share')
        g.custom_command('show-allowed-group', 'devicescloudprint_print_printer_show_allowed_group')
        g.custom_command('show-allowed-user', 'devicescloudprint_print_printer_show_allowed_user')
        g.custom_command('show-capability', 'devicescloudprint_print_printer_show_capability')
        g.custom_command('show-ref-share', 'devicescloudprint_print_printer_show_ref_share')
        g.custom_command('show-share', 'devicescloudprint_print_printer_show_share')
        g.custom_command('show-task-trigger', 'devicescloudprint_print_printer_show_task_trigger')
        g.custom_command('update-allowed-group', 'devicescloudprint_print_printer_update_allowed_group')
        g.custom_command('update-allowed-user', 'devicescloudprint_print_printer_update_allowed_user')
        g.custom_command('update-task-trigger', 'devicescloudprint_print_printer_update_task_trigger')

    with self.command_group(
        'devicescloudprint print-printer-task-trigger',
        devicescloudprint_beta_print_printer_task_trigger,
        client_factory=cf_print_printer_task_trigger,
    ) as g:
        g.custom_command('delete-ref-definition', 'devicescloudprint_print_printer_task_trigger_delete_ref_definition')
        g.custom_command('set-ref-definition', 'devicescloudprint_print_printer_task_trigger_set_ref_definition')
        g.custom_command('show-definition', 'devicescloudprint_print_printer_task_trigger_show_definition')
        g.custom_command('show-ref-definition', 'devicescloudprint_print_printer_task_trigger_show_ref_definition')

    with self.command_group(
        'devicescloudprint print-printer-share',
        devicescloudprint_beta_print_printer_share,
        client_factory=cf_print_printer_share,
    ) as g:
        g.custom_command('create-allowed-group', 'devicescloudprint_print_printer_share_create_allowed_group')
        g.custom_command('create-allowed-user', 'devicescloudprint_print_printer_share_create_allowed_user')
        g.custom_command('delete-allowed-group', 'devicescloudprint_print_printer_share_delete_allowed_group')
        g.custom_command('delete-allowed-user', 'devicescloudprint_print_printer_share_delete_allowed_user')
        g.custom_command('delete-ref-printer', 'devicescloudprint_print_printer_share_delete_ref_printer')
        g.custom_command('list-allowed-group', 'devicescloudprint_print_printer_share_list_allowed_group')
        g.custom_command('list-allowed-user', 'devicescloudprint_print_printer_share_list_allowed_user')
        g.custom_command('set-ref-printer', 'devicescloudprint_print_printer_share_set_ref_printer')
        g.custom_command('show-allowed-group', 'devicescloudprint_print_printer_share_show_allowed_group')
        g.custom_command('show-allowed-user', 'devicescloudprint_print_printer_share_show_allowed_user')
        g.custom_command('show-printer', 'devicescloudprint_print_printer_share_show_printer')
        g.custom_command('show-ref-printer', 'devicescloudprint_print_printer_share_show_ref_printer')
        g.custom_command('update-allowed-group', 'devicescloudprint_print_printer_share_update_allowed_group')
        g.custom_command('update-allowed-user', 'devicescloudprint_print_printer_share_update_allowed_user')

    with self.command_group(
        'devicescloudprint print-printer-share-printer',
        devicescloudprint_beta_print_printer_share_printer,
        client_factory=cf_print_printer_share_printer,
    ) as g:
        g.custom_command('reset-default', 'devicescloudprint_print_printer_share_printer_reset_default')
        g.custom_command(
            'restore-factory-default', 'devicescloudprint_print_printer_share_printer_restore_factory_default'
        )
        g.custom_command('show-capability', 'devicescloudprint_print_printer_share_printer_show_capability')

    with self.command_group(
        'devicescloudprint print-report', devicescloudprint_beta_print_report, client_factory=cf_print_report
    ) as g:
        g.custom_command(
            'show-group-archived-print-job', 'devicescloudprint_print_report_show_group_archived_print_job'
        )
        g.custom_command(
            'show-group-print-usage-summary', 'devicescloudprint_print_report_show_group_print_usage_summary'
        )
        g.custom_command(
            'show-overall-print-usage-summary', 'devicescloudprint_print_report_show_overall_print_usage_summary'
        )
        g.custom_command('show-print-usage-summary', 'devicescloudprint_print_report_show_print_usage_summary')
        g.custom_command(
            'show-printer-archived-print-job', 'devicescloudprint_print_report_show_printer_archived_print_job'
        )
        g.custom_command('show-printer-usage-summary', 'devicescloudprint_print_report_show_printer_usage_summary')
        g.custom_command('show-user-archived-print-job', 'devicescloudprint_print_report_show_user_archived_print_job')
        g.custom_command(
            'show-user-print-usage-summary', 'devicescloudprint_print_report_show_user_print_usage_summary'
        )

    with self.command_group(
        'devicescloudprint print-service', devicescloudprint_beta_print_service, client_factory=cf_print_service
    ) as g:
        g.custom_command('create-endpoint', 'devicescloudprint_print_service_create_endpoint')
        g.custom_command('delete-endpoint', 'devicescloudprint_print_service_delete_endpoint')
        g.custom_command('list-endpoint', 'devicescloudprint_print_service_list_endpoint')
        g.custom_command('show-endpoint', 'devicescloudprint_print_service_show_endpoint')
        g.custom_command('update-endpoint', 'devicescloudprint_print_service_update_endpoint')

    with self.command_group(
        'devicescloudprint print-share', devicescloudprint_beta_print_share, client_factory=cf_print_share
    ) as g:
        g.custom_command('create-allowed-group', 'devicescloudprint_print_share_create_allowed_group')
        g.custom_command('create-allowed-user', 'devicescloudprint_print_share_create_allowed_user')
        g.custom_command('delete-allowed-group', 'devicescloudprint_print_share_delete_allowed_group')
        g.custom_command('delete-allowed-user', 'devicescloudprint_print_share_delete_allowed_user')
        g.custom_command('delete-ref-printer', 'devicescloudprint_print_share_delete_ref_printer')
        g.custom_command('list-allowed-group', 'devicescloudprint_print_share_list_allowed_group')
        g.custom_command('list-allowed-user', 'devicescloudprint_print_share_list_allowed_user')
        g.custom_command('set-ref-printer', 'devicescloudprint_print_share_set_ref_printer')
        g.custom_command('show-allowed-group', 'devicescloudprint_print_share_show_allowed_group')
        g.custom_command('show-allowed-user', 'devicescloudprint_print_share_show_allowed_user')
        g.custom_command('show-printer', 'devicescloudprint_print_share_show_printer')
        g.custom_command('show-ref-printer', 'devicescloudprint_print_share_show_ref_printer')
        g.custom_command('update-allowed-group', 'devicescloudprint_print_share_update_allowed_group')
        g.custom_command('update-allowed-user', 'devicescloudprint_print_share_update_allowed_user')

    with self.command_group(
        'devicescloudprint print-share-printer',
        devicescloudprint_beta_print_share_printer,
        client_factory=cf_print_share_printer,
    ) as g:
        g.custom_command('reset-default', 'devicescloudprint_print_share_printer_reset_default')
        g.custom_command('restore-factory-default', 'devicescloudprint_print_share_printer_restore_factory_default')
        g.custom_command('show-capability', 'devicescloudprint_print_share_printer_show_capability')

    with self.command_group(
        'devicescloudprint print-task-definition',
        devicescloudprint_beta_print_task_definition,
        client_factory=cf_print_task_definition,
    ) as g:
        g.custom_command('create-task', 'devicescloudprint_print_task_definition_create_task')
        g.custom_command('delete-task', 'devicescloudprint_print_task_definition_delete_task')
        g.custom_command('list-task', 'devicescloudprint_print_task_definition_list_task')
        g.custom_command('show-task', 'devicescloudprint_print_task_definition_show_task')
        g.custom_command('update-task', 'devicescloudprint_print_task_definition_update_task')

    with self.command_group(
        'devicescloudprint print-task-definition-task',
        devicescloudprint_beta_print_task_definition_task,
        client_factory=cf_print_task_definition_task,
    ) as g:
        g.custom_command('delete-ref-definition', 'devicescloudprint_print_task_definition_task_delete_ref_definition')
        g.custom_command('delete-ref-trigger', 'devicescloudprint_print_task_definition_task_delete_ref_trigger')
        g.custom_command('set-ref-definition', 'devicescloudprint_print_task_definition_task_set_ref_definition')
        g.custom_command('set-ref-trigger', 'devicescloudprint_print_task_definition_task_set_ref_trigger')
        g.custom_command('show-definition', 'devicescloudprint_print_task_definition_task_show_definition')
        g.custom_command('show-ref-definition', 'devicescloudprint_print_task_definition_task_show_ref_definition')
        g.custom_command('show-ref-trigger', 'devicescloudprint_print_task_definition_task_show_ref_trigger')
        g.custom_command('show-trigger', 'devicescloudprint_print_task_definition_task_show_trigger')

    with self.command_group('devicescloudprint_beta', is_experimental=True):
        pass
