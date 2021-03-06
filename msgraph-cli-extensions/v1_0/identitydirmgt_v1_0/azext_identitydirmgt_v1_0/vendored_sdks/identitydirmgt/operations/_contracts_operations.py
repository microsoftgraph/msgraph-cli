# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# --------------------------------------------------------------------------
from typing import TYPE_CHECKING
import warnings

from azure.core.exceptions import ClientAuthenticationError, HttpResponseError, ResourceExistsError, ResourceNotFoundError, map_error
from azure.core.pipeline import PipelineResponse
from azure.core.pipeline.transport import HttpRequest, HttpResponse
from azure.mgmt.core.exceptions import ARMErrorFormat

from .. import models

if TYPE_CHECKING:
    # pylint: disable=unused-import,ungrouped-imports
    from typing import Any, Callable, Dict, Generic, List, Optional, TypeVar

    T = TypeVar('T')
    ClsType = Optional[Callable[[PipelineResponse[HttpRequest, HttpResponse], T, Dict[str, Any]], Any]]

class ContractsOperations(object):
    """ContractsOperations operations.

    You should not instantiate this class directly. Instead, you should create a Client instance that
    instantiates it for you and attaches it as an attribute.

    :ivar models: Alias to model classes used in this operation group.
    :type models: ~identity_directory_management.models
    :param client: Client for service requests.
    :param config: Configuration of service client.
    :param serializer: An object model serializer.
    :param deserializer: An object model deserializer.
    """

    models = models

    def __init__(self, client, config, serializer, deserializer):
        self._client = client
        self._serialize = serializer
        self._deserialize = deserializer
        self._config = config

    def check_member_groups(
        self,
        contract_id,  # type: str
        body,  # type: "models.Paths30M7S8ContractsContractIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema"
        **kwargs  # type: Any
    ):
        # type: (...) -> List[str]
        """Invoke action checkMemberGroups.

        Invoke action checkMemberGroups.

        :param contract_id: key: id of contract.
        :type contract_id: str
        :param body: Action parameters.
        :type body: ~identity_directory_management.models.Paths30M7S8ContractsContractIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema
        :keyword callable cls: A custom type or function that will be passed the direct response
        :return: list of str, or the result of cls(response)
        :rtype: list[str]
        :raises: ~azure.core.exceptions.HttpResponseError
        """
        cls = kwargs.pop('cls', None)  # type: ClsType[List[str]]
        error_map = {
            401: ClientAuthenticationError, 404: ResourceNotFoundError, 409: ResourceExistsError
        }
        error_map.update(kwargs.pop('error_map', {}))
        content_type = kwargs.pop("content_type", "application/json")
        accept = "application/json"

        # Construct URL
        url = self.check_member_groups.metadata['url']  # type: ignore
        path_format_arguments = {
            'contract-id': self._serialize.url("contract_id", contract_id, 'str'),
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}  # type: Dict[str, Any]

        # Construct headers
        header_parameters = {}  # type: Dict[str, Any]
        header_parameters['Content-Type'] = self._serialize.header("content_type", content_type, 'str')
        header_parameters['Accept'] = self._serialize.header("accept", accept, 'str')

        body_content_kwargs = {}  # type: Dict[str, Any]
        body_content = self._serialize.body(body, 'Paths30M7S8ContractsContractIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema')
        body_content_kwargs['content'] = body_content
        request = self._client.post(url, query_parameters, header_parameters, **body_content_kwargs)
        pipeline_response = self._client._pipeline.run(request, stream=False, **kwargs)
        response = pipeline_response.http_response

        if response.status_code not in [200]:
            map_error(status_code=response.status_code, response=response, error_map=error_map)
            error = self._deserialize(models.OdataError, response)
            raise HttpResponseError(response=response, model=error, error_format=ARMErrorFormat)

        deserialized = self._deserialize('[str]', pipeline_response)

        if cls:
            return cls(pipeline_response, deserialized, {})

        return deserialized
    check_member_groups.metadata = {'url': '/contracts/{contract-id}/microsoft.graph.checkMemberGroups'}  # type: ignore

    def check_member_objects(
        self,
        contract_id,  # type: str
        body,  # type: "models.PathsXq94UjContractsContractIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema"
        **kwargs  # type: Any
    ):
        # type: (...) -> List[str]
        """Invoke action checkMemberObjects.

        Invoke action checkMemberObjects.

        :param contract_id: key: id of contract.
        :type contract_id: str
        :param body: Action parameters.
        :type body: ~identity_directory_management.models.PathsXq94UjContractsContractIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema
        :keyword callable cls: A custom type or function that will be passed the direct response
        :return: list of str, or the result of cls(response)
        :rtype: list[str]
        :raises: ~azure.core.exceptions.HttpResponseError
        """
        cls = kwargs.pop('cls', None)  # type: ClsType[List[str]]
        error_map = {
            401: ClientAuthenticationError, 404: ResourceNotFoundError, 409: ResourceExistsError
        }
        error_map.update(kwargs.pop('error_map', {}))
        content_type = kwargs.pop("content_type", "application/json")
        accept = "application/json"

        # Construct URL
        url = self.check_member_objects.metadata['url']  # type: ignore
        path_format_arguments = {
            'contract-id': self._serialize.url("contract_id", contract_id, 'str'),
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}  # type: Dict[str, Any]

        # Construct headers
        header_parameters = {}  # type: Dict[str, Any]
        header_parameters['Content-Type'] = self._serialize.header("content_type", content_type, 'str')
        header_parameters['Accept'] = self._serialize.header("accept", accept, 'str')

        body_content_kwargs = {}  # type: Dict[str, Any]
        body_content = self._serialize.body(body, 'PathsXq94UjContractsContractIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema')
        body_content_kwargs['content'] = body_content
        request = self._client.post(url, query_parameters, header_parameters, **body_content_kwargs)
        pipeline_response = self._client._pipeline.run(request, stream=False, **kwargs)
        response = pipeline_response.http_response

        if response.status_code not in [200]:
            map_error(status_code=response.status_code, response=response, error_map=error_map)
            error = self._deserialize(models.OdataError, response)
            raise HttpResponseError(response=response, model=error, error_format=ARMErrorFormat)

        deserialized = self._deserialize('[str]', pipeline_response)

        if cls:
            return cls(pipeline_response, deserialized, {})

        return deserialized
    check_member_objects.metadata = {'url': '/contracts/{contract-id}/microsoft.graph.checkMemberObjects'}  # type: ignore

    def get_member_groups(
        self,
        contract_id,  # type: str
        body,  # type: "models.Paths9PdmsbContractsContractIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema"
        **kwargs  # type: Any
    ):
        # type: (...) -> List[str]
        """Invoke action getMemberGroups.

        Invoke action getMemberGroups.

        :param contract_id: key: id of contract.
        :type contract_id: str
        :param body: Action parameters.
        :type body: ~identity_directory_management.models.Paths9PdmsbContractsContractIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema
        :keyword callable cls: A custom type or function that will be passed the direct response
        :return: list of str, or the result of cls(response)
        :rtype: list[str]
        :raises: ~azure.core.exceptions.HttpResponseError
        """
        cls = kwargs.pop('cls', None)  # type: ClsType[List[str]]
        error_map = {
            401: ClientAuthenticationError, 404: ResourceNotFoundError, 409: ResourceExistsError
        }
        error_map.update(kwargs.pop('error_map', {}))
        content_type = kwargs.pop("content_type", "application/json")
        accept = "application/json"

        # Construct URL
        url = self.get_member_groups.metadata['url']  # type: ignore
        path_format_arguments = {
            'contract-id': self._serialize.url("contract_id", contract_id, 'str'),
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}  # type: Dict[str, Any]

        # Construct headers
        header_parameters = {}  # type: Dict[str, Any]
        header_parameters['Content-Type'] = self._serialize.header("content_type", content_type, 'str')
        header_parameters['Accept'] = self._serialize.header("accept", accept, 'str')

        body_content_kwargs = {}  # type: Dict[str, Any]
        body_content = self._serialize.body(body, 'Paths9PdmsbContractsContractIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema')
        body_content_kwargs['content'] = body_content
        request = self._client.post(url, query_parameters, header_parameters, **body_content_kwargs)
        pipeline_response = self._client._pipeline.run(request, stream=False, **kwargs)
        response = pipeline_response.http_response

        if response.status_code not in [200]:
            map_error(status_code=response.status_code, response=response, error_map=error_map)
            error = self._deserialize(models.OdataError, response)
            raise HttpResponseError(response=response, model=error, error_format=ARMErrorFormat)

        deserialized = self._deserialize('[str]', pipeline_response)

        if cls:
            return cls(pipeline_response, deserialized, {})

        return deserialized
    get_member_groups.metadata = {'url': '/contracts/{contract-id}/microsoft.graph.getMemberGroups'}  # type: ignore

    def get_member_objects(
        self,
        contract_id,  # type: str
        body,  # type: "models.Paths6Crxp6ContractsContractIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema"
        **kwargs  # type: Any
    ):
        # type: (...) -> List[str]
        """Invoke action getMemberObjects.

        Invoke action getMemberObjects.

        :param contract_id: key: id of contract.
        :type contract_id: str
        :param body: Action parameters.
        :type body: ~identity_directory_management.models.Paths6Crxp6ContractsContractIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema
        :keyword callable cls: A custom type or function that will be passed the direct response
        :return: list of str, or the result of cls(response)
        :rtype: list[str]
        :raises: ~azure.core.exceptions.HttpResponseError
        """
        cls = kwargs.pop('cls', None)  # type: ClsType[List[str]]
        error_map = {
            401: ClientAuthenticationError, 404: ResourceNotFoundError, 409: ResourceExistsError
        }
        error_map.update(kwargs.pop('error_map', {}))
        content_type = kwargs.pop("content_type", "application/json")
        accept = "application/json"

        # Construct URL
        url = self.get_member_objects.metadata['url']  # type: ignore
        path_format_arguments = {
            'contract-id': self._serialize.url("contract_id", contract_id, 'str'),
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}  # type: Dict[str, Any]

        # Construct headers
        header_parameters = {}  # type: Dict[str, Any]
        header_parameters['Content-Type'] = self._serialize.header("content_type", content_type, 'str')
        header_parameters['Accept'] = self._serialize.header("accept", accept, 'str')

        body_content_kwargs = {}  # type: Dict[str, Any]
        body_content = self._serialize.body(body, 'Paths6Crxp6ContractsContractIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema')
        body_content_kwargs['content'] = body_content
        request = self._client.post(url, query_parameters, header_parameters, **body_content_kwargs)
        pipeline_response = self._client._pipeline.run(request, stream=False, **kwargs)
        response = pipeline_response.http_response

        if response.status_code not in [200]:
            map_error(status_code=response.status_code, response=response, error_map=error_map)
            error = self._deserialize(models.OdataError, response)
            raise HttpResponseError(response=response, model=error, error_format=ARMErrorFormat)

        deserialized = self._deserialize('[str]', pipeline_response)

        if cls:
            return cls(pipeline_response, deserialized, {})

        return deserialized
    get_member_objects.metadata = {'url': '/contracts/{contract-id}/microsoft.graph.getMemberObjects'}  # type: ignore

    def restore(
        self,
        contract_id,  # type: str
        **kwargs  # type: Any
    ):
        # type: (...) -> "models.MicrosoftGraphDirectoryObject"
        """Invoke action restore.

        Invoke action restore.

        :param contract_id: key: id of contract.
        :type contract_id: str
        :keyword callable cls: A custom type or function that will be passed the direct response
        :return: MicrosoftGraphDirectoryObject, or the result of cls(response)
        :rtype: ~identity_directory_management.models.MicrosoftGraphDirectoryObject
        :raises: ~azure.core.exceptions.HttpResponseError
        """
        cls = kwargs.pop('cls', None)  # type: ClsType["models.MicrosoftGraphDirectoryObject"]
        error_map = {
            401: ClientAuthenticationError, 404: ResourceNotFoundError, 409: ResourceExistsError
        }
        error_map.update(kwargs.pop('error_map', {}))
        accept = "application/json"

        # Construct URL
        url = self.restore.metadata['url']  # type: ignore
        path_format_arguments = {
            'contract-id': self._serialize.url("contract_id", contract_id, 'str'),
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}  # type: Dict[str, Any]

        # Construct headers
        header_parameters = {}  # type: Dict[str, Any]
        header_parameters['Accept'] = self._serialize.header("accept", accept, 'str')

        request = self._client.post(url, query_parameters, header_parameters)
        pipeline_response = self._client._pipeline.run(request, stream=False, **kwargs)
        response = pipeline_response.http_response

        if response.status_code not in [200]:
            map_error(status_code=response.status_code, response=response, error_map=error_map)
            error = self._deserialize(models.OdataError, response)
            raise HttpResponseError(response=response, model=error, error_format=ARMErrorFormat)

        deserialized = self._deserialize('MicrosoftGraphDirectoryObject', pipeline_response)

        if cls:
            return cls(pipeline_response, deserialized, {})

        return deserialized
    restore.metadata = {'url': '/contracts/{contract-id}/microsoft.graph.restore'}  # type: ignore

    def get_available_extension_properties(
        self,
        body,  # type: "models.Paths2Yqm8DContractsMicrosoftGraphGetavailableextensionpropertiesPostRequestbodyContentApplicationJsonSchema"
        **kwargs  # type: Any
    ):
        # type: (...) -> List["models.MicrosoftGraphExtensionProperty"]
        """Invoke action getAvailableExtensionProperties.

        Invoke action getAvailableExtensionProperties.

        :param body: Action parameters.
        :type body: ~identity_directory_management.models.Paths2Yqm8DContractsMicrosoftGraphGetavailableextensionpropertiesPostRequestbodyContentApplicationJsonSchema
        :keyword callable cls: A custom type or function that will be passed the direct response
        :return: list of MicrosoftGraphExtensionProperty, or the result of cls(response)
        :rtype: list[~identity_directory_management.models.MicrosoftGraphExtensionProperty]
        :raises: ~azure.core.exceptions.HttpResponseError
        """
        cls = kwargs.pop('cls', None)  # type: ClsType[List["models.MicrosoftGraphExtensionProperty"]]
        error_map = {
            401: ClientAuthenticationError, 404: ResourceNotFoundError, 409: ResourceExistsError
        }
        error_map.update(kwargs.pop('error_map', {}))
        content_type = kwargs.pop("content_type", "application/json")
        accept = "application/json"

        # Construct URL
        url = self.get_available_extension_properties.metadata['url']  # type: ignore

        # Construct parameters
        query_parameters = {}  # type: Dict[str, Any]

        # Construct headers
        header_parameters = {}  # type: Dict[str, Any]
        header_parameters['Content-Type'] = self._serialize.header("content_type", content_type, 'str')
        header_parameters['Accept'] = self._serialize.header("accept", accept, 'str')

        body_content_kwargs = {}  # type: Dict[str, Any]
        body_content = self._serialize.body(body, 'Paths2Yqm8DContractsMicrosoftGraphGetavailableextensionpropertiesPostRequestbodyContentApplicationJsonSchema')
        body_content_kwargs['content'] = body_content
        request = self._client.post(url, query_parameters, header_parameters, **body_content_kwargs)
        pipeline_response = self._client._pipeline.run(request, stream=False, **kwargs)
        response = pipeline_response.http_response

        if response.status_code not in [200]:
            map_error(status_code=response.status_code, response=response, error_map=error_map)
            error = self._deserialize(models.OdataError, response)
            raise HttpResponseError(response=response, model=error, error_format=ARMErrorFormat)

        deserialized = self._deserialize('[MicrosoftGraphExtensionProperty]', pipeline_response)

        if cls:
            return cls(pipeline_response, deserialized, {})

        return deserialized
    get_available_extension_properties.metadata = {'url': '/contracts/microsoft.graph.getAvailableExtensionProperties'}  # type: ignore

    def get_by_ids(
        self,
        body,  # type: "models.Paths1T6Lra6ContractsMicrosoftGraphGetbyidsPostRequestbodyContentApplicationJsonSchema"
        **kwargs  # type: Any
    ):
        # type: (...) -> List["models.MicrosoftGraphDirectoryObject"]
        """Invoke action getByIds.

        Invoke action getByIds.

        :param body: Action parameters.
        :type body: ~identity_directory_management.models.Paths1T6Lra6ContractsMicrosoftGraphGetbyidsPostRequestbodyContentApplicationJsonSchema
        :keyword callable cls: A custom type or function that will be passed the direct response
        :return: list of MicrosoftGraphDirectoryObject, or the result of cls(response)
        :rtype: list[~identity_directory_management.models.MicrosoftGraphDirectoryObject]
        :raises: ~azure.core.exceptions.HttpResponseError
        """
        cls = kwargs.pop('cls', None)  # type: ClsType[List["models.MicrosoftGraphDirectoryObject"]]
        error_map = {
            401: ClientAuthenticationError, 404: ResourceNotFoundError, 409: ResourceExistsError
        }
        error_map.update(kwargs.pop('error_map', {}))
        content_type = kwargs.pop("content_type", "application/json")
        accept = "application/json"

        # Construct URL
        url = self.get_by_ids.metadata['url']  # type: ignore

        # Construct parameters
        query_parameters = {}  # type: Dict[str, Any]

        # Construct headers
        header_parameters = {}  # type: Dict[str, Any]
        header_parameters['Content-Type'] = self._serialize.header("content_type", content_type, 'str')
        header_parameters['Accept'] = self._serialize.header("accept", accept, 'str')

        body_content_kwargs = {}  # type: Dict[str, Any]
        body_content = self._serialize.body(body, 'Paths1T6Lra6ContractsMicrosoftGraphGetbyidsPostRequestbodyContentApplicationJsonSchema')
        body_content_kwargs['content'] = body_content
        request = self._client.post(url, query_parameters, header_parameters, **body_content_kwargs)
        pipeline_response = self._client._pipeline.run(request, stream=False, **kwargs)
        response = pipeline_response.http_response

        if response.status_code not in [200]:
            map_error(status_code=response.status_code, response=response, error_map=error_map)
            error = self._deserialize(models.OdataError, response)
            raise HttpResponseError(response=response, model=error, error_format=ARMErrorFormat)

        deserialized = self._deserialize('[MicrosoftGraphDirectoryObject]', pipeline_response)

        if cls:
            return cls(pipeline_response, deserialized, {})

        return deserialized
    get_by_ids.metadata = {'url': '/contracts/microsoft.graph.getByIds'}  # type: ignore

    def validate_properties(
        self,
        body,  # type: "models.PathsZahmwmContractsMicrosoftGraphValidatepropertiesPostRequestbodyContentApplicationJsonSchema"
        **kwargs  # type: Any
    ):
        # type: (...) -> None
        """Invoke action validateProperties.

        Invoke action validateProperties.

        :param body: Action parameters.
        :type body: ~identity_directory_management.models.PathsZahmwmContractsMicrosoftGraphValidatepropertiesPostRequestbodyContentApplicationJsonSchema
        :keyword callable cls: A custom type or function that will be passed the direct response
        :return: None, or the result of cls(response)
        :rtype: None
        :raises: ~azure.core.exceptions.HttpResponseError
        """
        cls = kwargs.pop('cls', None)  # type: ClsType[None]
        error_map = {
            401: ClientAuthenticationError, 404: ResourceNotFoundError, 409: ResourceExistsError
        }
        error_map.update(kwargs.pop('error_map', {}))
        content_type = kwargs.pop("content_type", "application/json")
        accept = "application/json"

        # Construct URL
        url = self.validate_properties.metadata['url']  # type: ignore

        # Construct parameters
        query_parameters = {}  # type: Dict[str, Any]

        # Construct headers
        header_parameters = {}  # type: Dict[str, Any]
        header_parameters['Content-Type'] = self._serialize.header("content_type", content_type, 'str')
        header_parameters['Accept'] = self._serialize.header("accept", accept, 'str')

        body_content_kwargs = {}  # type: Dict[str, Any]
        body_content = self._serialize.body(body, 'PathsZahmwmContractsMicrosoftGraphValidatepropertiesPostRequestbodyContentApplicationJsonSchema')
        body_content_kwargs['content'] = body_content
        request = self._client.post(url, query_parameters, header_parameters, **body_content_kwargs)
        pipeline_response = self._client._pipeline.run(request, stream=False, **kwargs)
        response = pipeline_response.http_response

        if response.status_code not in [204]:
            map_error(status_code=response.status_code, response=response, error_map=error_map)
            error = self._deserialize(models.OdataError, response)
            raise HttpResponseError(response=response, model=error, error_format=ARMErrorFormat)

        if cls:
            return cls(pipeline_response, None, {})

    validate_properties.metadata = {'url': '/contracts/microsoft.graph.validateProperties'}  # type: ignore
