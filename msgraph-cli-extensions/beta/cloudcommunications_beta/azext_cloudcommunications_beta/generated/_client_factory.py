# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------


def cf_cloudcommunications_beta_cl(cli_ctx, *_):
    from msgraph.cli.core.commands.client_factory import get_mgmt_service_client
    from azext_cloudcommunications_beta.vendored_sdks.cloudcommunications import CloudCommunications
    return get_mgmt_service_client(cli_ctx,
                                   CloudCommunications,
                                   subscription_bound=False,
                                   base_url_bound=False)


def cf_communication_cloud_communication(cli_ctx, *_):
    return cf_cloudcommunications_beta_cl(cli_ctx).communications_cloud_communications


def cf_communication(cli_ctx, *_):
    return cf_cloudcommunications_beta_cl(cli_ctx).communications


def cf_communication_call_record(cli_ctx, *_):
    return cf_cloudcommunications_beta_cl(cli_ctx).communications_call_records


def cf_communication_call_record_session(cli_ctx, *_):
    return cf_cloudcommunications_beta_cl(cli_ctx).communications_call_records_sessions


def cf_communication_call(cli_ctx, *_):
    return cf_cloudcommunications_beta_cl(cli_ctx).communications_calls


def cf_communication_call_participant(cli_ctx, *_):
    return cf_cloudcommunications_beta_cl(cli_ctx).communications_calls_participants


def cf_communication_online_meeting(cli_ctx, *_):
    return cf_cloudcommunications_beta_cl(cli_ctx).communications_online_meetings


def cf_user(cli_ctx, *_):
    return cf_cloudcommunications_beta_cl(cli_ctx).users
