# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# --------------------------------------------------------------------------

from typing import Any, Optional, TYPE_CHECKING

from azure.mgmt.core import AsyncARMPipelineClient
from msrest import Deserializer, Serializer

if TYPE_CHECKING:
    # pylint: disable=unused-import,ungrouped-imports
    from azure.core.credentials_async import AsyncTokenCredential

from ._configuration import FilesConfiguration
from .operations import DrivesDriveOperations
from .operations import DrivesOperations
from .operations import DrivesActivitiesOperations
from .operations import DrivesActivitiesListItemOperations
from .operations import DrivesActivitiesListItemVersionsOperations
from .operations import DrivesListOperations
from .operations import DrivesListActivitiesOperations
from .operations import DrivesListActivitiesListItemOperations
from .operations import DrivesListActivitiesListItemVersionsOperations
from .operations import DrivesListContentTypesOperations
from .operations import DrivesListItemsOperations
from .operations import DrivesListItemsActivitiesOperations
from .operations import DrivesListItemsActivitiesListItemOperations
from .operations import DrivesListItemsVersionsOperations
from .operations import GroupsOperations
from .operations import SharesSharedDriveItemOperations
from .operations import SharesOperations
from .operations import SharesListOperations
from .operations import SharesListActivitiesOperations
from .operations import SharesListActivitiesListItemOperations
from .operations import SharesListActivitiesListItemVersionsOperations
from .operations import SharesListContentTypesOperations
from .operations import SharesListItemsOperations
from .operations import SharesListItemsActivitiesOperations
from .operations import SharesListItemsActivitiesListItemOperations
from .operations import SharesListItemsVersionsOperations
from .operations import SharesListItemOperations
from .operations import SharesListItemActivitiesOperations
from .operations import SharesListItemActivitiesListItemOperations
from .operations import SharesListItemVersionsOperations
from .operations import SharesPermissionOperations
from .operations import UsersOperations
from .. import models


class Files(object):
    """Files.

    :ivar drives_drive: DrivesDriveOperations operations
    :vartype drives_drive: files.aio.operations.DrivesDriveOperations
    :ivar drives: DrivesOperations operations
    :vartype drives: files.aio.operations.DrivesOperations
    :ivar drives_activities: DrivesActivitiesOperations operations
    :vartype drives_activities: files.aio.operations.DrivesActivitiesOperations
    :ivar drives_activities_list_item: DrivesActivitiesListItemOperations operations
    :vartype drives_activities_list_item: files.aio.operations.DrivesActivitiesListItemOperations
    :ivar drives_activities_list_item_versions: DrivesActivitiesListItemVersionsOperations operations
    :vartype drives_activities_list_item_versions: files.aio.operations.DrivesActivitiesListItemVersionsOperations
    :ivar drives_list: DrivesListOperations operations
    :vartype drives_list: files.aio.operations.DrivesListOperations
    :ivar drives_list_activities: DrivesListActivitiesOperations operations
    :vartype drives_list_activities: files.aio.operations.DrivesListActivitiesOperations
    :ivar drives_list_activities_list_item: DrivesListActivitiesListItemOperations operations
    :vartype drives_list_activities_list_item: files.aio.operations.DrivesListActivitiesListItemOperations
    :ivar drives_list_activities_list_item_versions: DrivesListActivitiesListItemVersionsOperations operations
    :vartype drives_list_activities_list_item_versions: files.aio.operations.DrivesListActivitiesListItemVersionsOperations
    :ivar drives_list_content_types: DrivesListContentTypesOperations operations
    :vartype drives_list_content_types: files.aio.operations.DrivesListContentTypesOperations
    :ivar drives_list_items: DrivesListItemsOperations operations
    :vartype drives_list_items: files.aio.operations.DrivesListItemsOperations
    :ivar drives_list_items_activities: DrivesListItemsActivitiesOperations operations
    :vartype drives_list_items_activities: files.aio.operations.DrivesListItemsActivitiesOperations
    :ivar drives_list_items_activities_list_item: DrivesListItemsActivitiesListItemOperations operations
    :vartype drives_list_items_activities_list_item: files.aio.operations.DrivesListItemsActivitiesListItemOperations
    :ivar drives_list_items_versions: DrivesListItemsVersionsOperations operations
    :vartype drives_list_items_versions: files.aio.operations.DrivesListItemsVersionsOperations
    :ivar groups: GroupsOperations operations
    :vartype groups: files.aio.operations.GroupsOperations
    :ivar shares_shared_drive_item: SharesSharedDriveItemOperations operations
    :vartype shares_shared_drive_item: files.aio.operations.SharesSharedDriveItemOperations
    :ivar shares: SharesOperations operations
    :vartype shares: files.aio.operations.SharesOperations
    :ivar shares_list: SharesListOperations operations
    :vartype shares_list: files.aio.operations.SharesListOperations
    :ivar shares_list_activities: SharesListActivitiesOperations operations
    :vartype shares_list_activities: files.aio.operations.SharesListActivitiesOperations
    :ivar shares_list_activities_list_item: SharesListActivitiesListItemOperations operations
    :vartype shares_list_activities_list_item: files.aio.operations.SharesListActivitiesListItemOperations
    :ivar shares_list_activities_list_item_versions: SharesListActivitiesListItemVersionsOperations operations
    :vartype shares_list_activities_list_item_versions: files.aio.operations.SharesListActivitiesListItemVersionsOperations
    :ivar shares_list_content_types: SharesListContentTypesOperations operations
    :vartype shares_list_content_types: files.aio.operations.SharesListContentTypesOperations
    :ivar shares_list_items: SharesListItemsOperations operations
    :vartype shares_list_items: files.aio.operations.SharesListItemsOperations
    :ivar shares_list_items_activities: SharesListItemsActivitiesOperations operations
    :vartype shares_list_items_activities: files.aio.operations.SharesListItemsActivitiesOperations
    :ivar shares_list_items_activities_list_item: SharesListItemsActivitiesListItemOperations operations
    :vartype shares_list_items_activities_list_item: files.aio.operations.SharesListItemsActivitiesListItemOperations
    :ivar shares_list_items_versions: SharesListItemsVersionsOperations operations
    :vartype shares_list_items_versions: files.aio.operations.SharesListItemsVersionsOperations
    :ivar shares_list_item: SharesListItemOperations operations
    :vartype shares_list_item: files.aio.operations.SharesListItemOperations
    :ivar shares_list_item_activities: SharesListItemActivitiesOperations operations
    :vartype shares_list_item_activities: files.aio.operations.SharesListItemActivitiesOperations
    :ivar shares_list_item_activities_list_item: SharesListItemActivitiesListItemOperations operations
    :vartype shares_list_item_activities_list_item: files.aio.operations.SharesListItemActivitiesListItemOperations
    :ivar shares_list_item_versions: SharesListItemVersionsOperations operations
    :vartype shares_list_item_versions: files.aio.operations.SharesListItemVersionsOperations
    :ivar shares_permission: SharesPermissionOperations operations
    :vartype shares_permission: files.aio.operations.SharesPermissionOperations
    :ivar users: UsersOperations operations
    :vartype users: files.aio.operations.UsersOperations
    :param credential: Credential needed for the client to connect to Azure.
    :type credential: ~azure.core.credentials_async.AsyncTokenCredential
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
        credential: "AsyncTokenCredential",
        top: Optional[int] = None,
        skip: Optional[int] = None,
        search: Optional[str] = None,
        filter: Optional[str] = None,
        count: Optional[bool] = None,
        base_url: Optional[str] = None,
        **kwargs: Any
    ) -> None:
        if not base_url:
            base_url = 'https://graph.microsoft.com/beta'
        self._config = FilesConfiguration(credential, top, skip, search, filter, count, **kwargs)
        self._client = AsyncARMPipelineClient(base_url=base_url, config=self._config, **kwargs)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer(client_models)
        self._serialize.client_side_validation = False
        self._deserialize = Deserializer(client_models)

        self.drives_drive = DrivesDriveOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives = DrivesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives_activities = DrivesActivitiesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives_activities_list_item = DrivesActivitiesListItemOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives_activities_list_item_versions = DrivesActivitiesListItemVersionsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives_list = DrivesListOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives_list_activities = DrivesListActivitiesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives_list_activities_list_item = DrivesListActivitiesListItemOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives_list_activities_list_item_versions = DrivesListActivitiesListItemVersionsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives_list_content_types = DrivesListContentTypesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives_list_items = DrivesListItemsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives_list_items_activities = DrivesListItemsActivitiesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives_list_items_activities_list_item = DrivesListItemsActivitiesListItemOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.drives_list_items_versions = DrivesListItemsVersionsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.groups = GroupsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_shared_drive_item = SharesSharedDriveItemOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares = SharesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list = SharesListOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list_activities = SharesListActivitiesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list_activities_list_item = SharesListActivitiesListItemOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list_activities_list_item_versions = SharesListActivitiesListItemVersionsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list_content_types = SharesListContentTypesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list_items = SharesListItemsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list_items_activities = SharesListItemsActivitiesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list_items_activities_list_item = SharesListItemsActivitiesListItemOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list_items_versions = SharesListItemsVersionsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list_item = SharesListItemOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list_item_activities = SharesListItemActivitiesOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list_item_activities_list_item = SharesListItemActivitiesListItemOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_list_item_versions = SharesListItemVersionsOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.shares_permission = SharesPermissionOperations(
            self._client, self._config, self._serialize, self._deserialize)
        self.users = UsersOperations(
            self._client, self._config, self._serialize, self._deserialize)

    async def close(self) -> None:
        await self._client.close()

    async def __aenter__(self) -> "Files":
        await self._client.__aenter__()
        return self

    async def __aexit__(self, *exc_details) -> None:
        await self._client.__aexit__(*exc_details)
