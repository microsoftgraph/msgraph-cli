# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# --------------------------------------------------------------------------

from typing import TYPE_CHECKING

from azure.mgmt.core import ARMPipelineClient
from msrest import Deserializer, Serializer

if TYPE_CHECKING:
    # pylint: disable=unused-import,ungrouped-imports
    from typing import Any, Optional

    from azure.core.credentials import TokenCredential

from ._configuration import DevicesCorporateManagementConfiguration
from .operations import DeviceAppManagementDeviceAppManagementOperations
from .operations import DeviceAppManagementOperations
from .operations import DeviceAppManagementAndroidManagedAppProtectionsOperations
from .operations import DeviceAppManagementDefaultManagedAppProtectionsOperations
from .operations import DeviceAppManagementIosManagedAppProtectionsOperations
from .operations import DeviceAppManagementManagedAppPoliciesOperations
from .operations import DeviceAppManagementManagedAppRegistrationsOperations
from .operations import DeviceAppManagementManagedAppRegistrationsAppliedPoliciesOperations
from .operations import DeviceAppManagementManagedAppRegistrationsIntendedPoliciesOperations
from .operations import DeviceAppManagementManagedEBooksOperations
from .operations import DeviceAppManagementManagedEBooksUserStateSummaryOperations
from .operations import DeviceAppManagementMobileAppConfigurationsOperations
from .operations import DeviceAppManagementMobileAppsOperations
from .operations import DeviceAppManagementTargetedManagedAppConfigurationsOperations
from .operations import DeviceAppManagementVppTokensOperations
from .operations import UsersOperations
from .operations import UsersManagedDevicesOperations
from . import models


class DevicesCorporateManagement(object):
    """DevicesCorporateManagement.

    :ivar device_app_management_device_app_management: DeviceAppManagementDeviceAppManagementOperations operations
    :vartype device_app_management_device_app_management: devices_corporate_management.operations.DeviceAppManagementDeviceAppManagementOperations
    :ivar device_app_management: DeviceAppManagementOperations operations
    :vartype device_app_management: devices_corporate_management.operations.DeviceAppManagementOperations
    :ivar device_app_management_android_managed_app_protections: DeviceAppManagementAndroidManagedAppProtectionsOperations operations
    :vartype device_app_management_android_managed_app_protections: devices_corporate_management.operations.DeviceAppManagementAndroidManagedAppProtectionsOperations
    :ivar device_app_management_default_managed_app_protections: DeviceAppManagementDefaultManagedAppProtectionsOperations operations
    :vartype device_app_management_default_managed_app_protections: devices_corporate_management.operations.DeviceAppManagementDefaultManagedAppProtectionsOperations
    :ivar device_app_management_ios_managed_app_protections: DeviceAppManagementIosManagedAppProtectionsOperations operations
    :vartype device_app_management_ios_managed_app_protections: devices_corporate_management.operations.DeviceAppManagementIosManagedAppProtectionsOperations
    :ivar device_app_management_managed_app_policies: DeviceAppManagementManagedAppPoliciesOperations operations
    :vartype device_app_management_managed_app_policies: devices_corporate_management.operations.DeviceAppManagementManagedAppPoliciesOperations
    :ivar device_app_management_managed_app_registrations: DeviceAppManagementManagedAppRegistrationsOperations operations
    :vartype device_app_management_managed_app_registrations: devices_corporate_management.operations.DeviceAppManagementManagedAppRegistrationsOperations
    :ivar device_app_management_managed_app_registrations_applied_policies: DeviceAppManagementManagedAppRegistrationsAppliedPoliciesOperations operations
    :vartype device_app_management_managed_app_registrations_applied_policies: devices_corporate_management.operations.DeviceAppManagementManagedAppRegistrationsAppliedPoliciesOperations
    :ivar device_app_management_managed_app_registrations_intended_policies: DeviceAppManagementManagedAppRegistrationsIntendedPoliciesOperations operations
    :vartype device_app_management_managed_app_registrations_intended_policies: devices_corporate_management.operations.DeviceAppManagementManagedAppRegistrationsIntendedPoliciesOperations
    :ivar device_app_management_managed_ebooks: DeviceAppManagementManagedEBooksOperations operations
    :vartype device_app_management_managed_ebooks: devices_corporate_management.operations.DeviceAppManagementManagedEBooksOperations
    :ivar device_app_management_managed_ebooks_user_state_summary: DeviceAppManagementManagedEBooksUserStateSummaryOperations operations
    :vartype device_app_management_managed_ebooks_user_state_summary: devices_corporate_management.operations.DeviceAppManagementManagedEBooksUserStateSummaryOperations
    :ivar device_app_management_mobile_app_configurations: DeviceAppManagementMobileAppConfigurationsOperations operations
    :vartype device_app_management_mobile_app_configurations: devices_corporate_management.operations.DeviceAppManagementMobileAppConfigurationsOperations
    :ivar device_app_management_mobile_apps: DeviceAppManagementMobileAppsOperations operations
    :vartype device_app_management_mobile_apps: devices_corporate_management.operations.DeviceAppManagementMobileAppsOperations
    :ivar device_app_management_targeted_managed_app_configurations: DeviceAppManagementTargetedManagedAppConfigurationsOperations operations
    :vartype device_app_management_targeted_managed_app_configurations: devices_corporate_management.operations.DeviceAppManagementTargetedManagedAppConfigurationsOperations
    :ivar device_app_management_vpp_tokens: DeviceAppManagementVppTokensOperations operations
    :vartype device_app_management_vpp_tokens: devices_corporate_management.operations.DeviceAppManagementVppTokensOperations
    :ivar users: UsersOperations operations
    :vartype users: devices_corporate_management.operations.UsersOperations
    :ivar users_managed_devices: UsersManagedDevicesOperations operations
    :vartype users_managed_devices: devices_corporate_management.operations.UsersManagedDevicesOperations
    :param credential: Credential needed for the client to connect to Azure.
    :type credential: ~azure.core.credentials.TokenCredential
    :param top: Show only the first n items.
    :type top: int
    :param skip: Skip the first n items.
    :type skip: int
    :param search: Search items by search phrases.
    :type search: str
    :param filter: Filter items by property values.
    :type filter: str
    :param count: Include count of items.
    :type count: bool
    :param str base_url: Service URL
    """

    def __init__(
        self,
        credential,  # type: "TokenCredential"
        top=None,  # type: Optional[int]
        skip=None,  # type: Optional[int]
        search=None,  # type: Optional[str]
        filter=None,  # type: Optional[str]
        count=None,  # type: Optional[bool]
        base_url=None,  # type: Optional[str]
        **kwargs  # type: Any
    ):
        # type: (...) -> None
        if not base_url:
            base_url = 'https://graph.microsoft.com/v1.0'
        self._config = DevicesCorporateManagementConfiguration(credential, top, skip, search, filter, count, **kwargs)
        self._client = ARMPipelineClient(base_url=base_url, config=self._config, **kwargs)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer(client_models)
        self._serialize.client_side_validation = False
        self._deserialize = Deserializer(client_models)

        self.device_app_management_device_app_management = DeviceAppManagementDeviceAppManagementOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management = DeviceAppManagementOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_android_managed_app_protections = DeviceAppManagementAndroidManagedAppProtectionsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_default_managed_app_protections = DeviceAppManagementDefaultManagedAppProtectionsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_ios_managed_app_protections = DeviceAppManagementIosManagedAppProtectionsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_managed_app_policies = DeviceAppManagementManagedAppPoliciesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_managed_app_registrations = DeviceAppManagementManagedAppRegistrationsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_managed_app_registrations_applied_policies = DeviceAppManagementManagedAppRegistrationsAppliedPoliciesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_managed_app_registrations_intended_policies = DeviceAppManagementManagedAppRegistrationsIntendedPoliciesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_managed_ebooks = DeviceAppManagementManagedEBooksOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_managed_ebooks_user_state_summary = DeviceAppManagementManagedEBooksUserStateSummaryOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_mobile_app_configurations = DeviceAppManagementMobileAppConfigurationsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_mobile_apps = DeviceAppManagementMobileAppsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_targeted_managed_app_configurations = DeviceAppManagementTargetedManagedAppConfigurationsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.device_app_management_vpp_tokens = DeviceAppManagementVppTokensOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.users = UsersOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.users_managed_devices = UsersManagedDevicesOperations(
            self._client, self._config, self._serialize, self._deserialize)

    def close(self):
        # type: () -> None
        self._client.close()

    def __enter__(self):
        # type: () -> DevicesCorporateManagement
        self._client.__enter__()
        return self

    def __exit__(self, *exc_details):
        # type: (Any) -> None
        self._client.__exit__(*exc_details)
