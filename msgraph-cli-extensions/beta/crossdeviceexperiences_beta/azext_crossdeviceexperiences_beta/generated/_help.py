# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------
# pylint: disable=too-many-lines

from knack.help_files import helps


helps['crossdeviceexperiences_beta'] = '''
    type: group
    short-summary: Manage Cross Device Experiences
'''

helps['crossdeviceexperiences user'] = """
    type: group
    short-summary: Manage user with crossdeviceexperiences_beta
"""

helps['crossdeviceexperiences user create-activity'] = """
    type: command
    short-summary: "Create new navigation property to activities for users."
    parameters:
      - name: --attribution
        short-summary: "imageInfo"
        long-summary: |
            Usage: --attribution add-image-query=XX alternate-text=XX alternative-text=XX icon-url=XX

            add-image-query: Optional; parameter used to indicate the server is able to render image dynamically in \
response to parameterization. For example – a high contrast image
            alternate-text: Optional; alt-text accessible content for the image
            icon-url: Optional; URI that points to an icon which represents the application used to generate the \
activity
"""

helps['crossdeviceexperiences user create-device'] = """
    type: command
    short-summary: "Create new navigation property to devices for users."
    parameters:
      - name: --alternative-security-ids
        short-summary: "For internal use only. Not nullable."
        long-summary: |
            Usage: --alternative-security-ids identity-provider=XX key=XX type=XX

            identity-provider: For internal use only
            key: For internal use only
            type: For internal use only

            Multiple actions can be specified by using more than one --alternative-security-ids argument.
      - name: --extension-attributes
        short-summary: "onPremisesExtensionAttributes"
        long-summary: |
            Usage: --extension-attributes extension-attribute1=XX extension-attribute10=XX extension-attribute11=XX \
extension-attribute12=XX extension-attribute13=XX extension-attribute14=XX extension-attribute15=XX \
extension-attribute2=XX extension-attribute3=XX extension-attribute4=XX extension-attribute5=XX \
extension-attribute6=XX extension-attribute7=XX extension-attribute8=XX extension-attribute9=XX

            extension-attribute1: First customizable extension attribute.
            extension-attribute10: Tenth customizable extension attribute.
            extension-attribute11: Eleventh customizable extension attribute.
            extension-attribute12: Twelfth customizable extension attribute.
            extension-attribute13: Thirteenth customizable extension attribute.
            extension-attribute14: Fourteenth customizable extension attribute.
            extension-attribute15: Fifteenth customizable extension attribute.
            extension-attribute2: Second customizable extension attribute.
            extension-attribute3: Third customizable extension attribute.
            extension-attribute4: Fourth customizable extension attribute.
            extension-attribute5: Fifth customizable extension attribute.
            extension-attribute6: Sixth customizable extension attribute.
            extension-attribute7: Seventh customizable extension attribute.
            extension-attribute8: Eighth customizable extension attribute.
            extension-attribute9: Ninth customizable extension attribute.
      - name: --member-of
        short-summary: "Groups that this group is a member of. HTTP Methods: GET (supported for all groups). \
Read-only. Nullable."
        long-summary: |
            Usage: --member-of deleted-date-time=XX id=XX

            id: Read-only.

            Multiple actions can be specified by using more than one --member-of argument.
      - name: --registered-owners
        short-summary: "The user that cloud joined the device or registered their personal device. The registered \
owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable."
        long-summary: |
            Usage: --registered-owners deleted-date-time=XX id=XX

            id: Read-only.

            Multiple actions can be specified by using more than one --registered-owners argument.
      - name: --registered-users
        short-summary: "Collection of registered users of the device. For cloud joined devices and registered personal \
devices, registered users are set to the same value as registered owners at the time of registration. Read-only. \
Nullable."
        long-summary: |
            Usage: --registered-users deleted-date-time=XX id=XX

            id: Read-only.

            Multiple actions can be specified by using more than one --registered-users argument.
      - name: --transitive-member-of
        long-summary: |
            Usage: --transitive-member-of deleted-date-time=XX id=XX

            id: Read-only.

            Multiple actions can be specified by using more than one --transitive-member-of argument.
      - name: --extensions
        short-summary: "The collection of open extensions defined for the device. Read-only. Nullable."
        long-summary: |
            Usage: --extensions id=XX

            id: Read-only.

            Multiple actions can be specified by using more than one --extensions argument.
"""

helps['crossdeviceexperiences user delete-activity'] = """
    type: command
    short-summary: "Delete navigation property activities for users."
"""

helps['crossdeviceexperiences user delete-device'] = """
    type: command
    short-summary: "Delete navigation property devices for users."
"""

helps['crossdeviceexperiences user list-activity'] = """
    type: command
    short-summary: "Get activities from users."
"""

helps['crossdeviceexperiences user list-device'] = """
    type: command
    short-summary: "Get devices from users."
"""

helps['crossdeviceexperiences user show-activity'] = """
    type: command
    short-summary: "Get activities from users."
"""

helps['crossdeviceexperiences user show-device'] = """
    type: command
    short-summary: "Get devices from users."
"""

helps['crossdeviceexperiences user update-activity'] = """
    type: command
    short-summary: "Update the navigation property activities in users."
    parameters:
      - name: --attribution
        short-summary: "imageInfo"
        long-summary: |
            Usage: --attribution add-image-query=XX alternate-text=XX alternative-text=XX icon-url=XX

            add-image-query: Optional; parameter used to indicate the server is able to render image dynamically in \
response to parameterization. For example – a high contrast image
            alternate-text: Optional; alt-text accessible content for the image
            icon-url: Optional; URI that points to an icon which represents the application used to generate the \
activity
"""

helps['crossdeviceexperiences user update-device'] = """
    type: command
    short-summary: "Update the navigation property devices in users."
    parameters:
      - name: --alternative-security-ids
        short-summary: "For internal use only. Not nullable."
        long-summary: |
            Usage: --alternative-security-ids identity-provider=XX key=XX type=XX

            identity-provider: For internal use only
            key: For internal use only
            type: For internal use only

            Multiple actions can be specified by using more than one --alternative-security-ids argument.
      - name: --extension-attributes
        short-summary: "onPremisesExtensionAttributes"
        long-summary: |
            Usage: --extension-attributes extension-attribute1=XX extension-attribute10=XX extension-attribute11=XX \
extension-attribute12=XX extension-attribute13=XX extension-attribute14=XX extension-attribute15=XX \
extension-attribute2=XX extension-attribute3=XX extension-attribute4=XX extension-attribute5=XX \
extension-attribute6=XX extension-attribute7=XX extension-attribute8=XX extension-attribute9=XX

            extension-attribute1: First customizable extension attribute.
            extension-attribute10: Tenth customizable extension attribute.
            extension-attribute11: Eleventh customizable extension attribute.
            extension-attribute12: Twelfth customizable extension attribute.
            extension-attribute13: Thirteenth customizable extension attribute.
            extension-attribute14: Fourteenth customizable extension attribute.
            extension-attribute15: Fifteenth customizable extension attribute.
            extension-attribute2: Second customizable extension attribute.
            extension-attribute3: Third customizable extension attribute.
            extension-attribute4: Fourth customizable extension attribute.
            extension-attribute5: Fifth customizable extension attribute.
            extension-attribute6: Sixth customizable extension attribute.
            extension-attribute7: Seventh customizable extension attribute.
            extension-attribute8: Eighth customizable extension attribute.
            extension-attribute9: Ninth customizable extension attribute.
      - name: --member-of
        short-summary: "Groups that this group is a member of. HTTP Methods: GET (supported for all groups). \
Read-only. Nullable."
        long-summary: |
            Usage: --member-of deleted-date-time=XX id=XX

            id: Read-only.

            Multiple actions can be specified by using more than one --member-of argument.
      - name: --registered-owners
        short-summary: "The user that cloud joined the device or registered their personal device. The registered \
owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable."
        long-summary: |
            Usage: --registered-owners deleted-date-time=XX id=XX

            id: Read-only.

            Multiple actions can be specified by using more than one --registered-owners argument.
      - name: --registered-users
        short-summary: "Collection of registered users of the device. For cloud joined devices and registered personal \
devices, registered users are set to the same value as registered owners at the time of registration. Read-only. \
Nullable."
        long-summary: |
            Usage: --registered-users deleted-date-time=XX id=XX

            id: Read-only.

            Multiple actions can be specified by using more than one --registered-users argument.
      - name: --transitive-member-of
        long-summary: |
            Usage: --transitive-member-of deleted-date-time=XX id=XX

            id: Read-only.

            Multiple actions can be specified by using more than one --transitive-member-of argument.
      - name: --extensions
        short-summary: "The collection of open extensions defined for the device. Read-only. Nullable."
        long-summary: |
            Usage: --extensions id=XX

            id: Read-only.

            Multiple actions can be specified by using more than one --extensions argument.
"""

helps['crossdeviceexperiences user-activity'] = """
    type: group
    short-summary: Manage user activity with crossdeviceexperiences_beta
"""

helps['crossdeviceexperiences user-activity create-history-item'] = """
    type: command
    short-summary: "Create new navigation property to historyItems for users."
"""

helps['crossdeviceexperiences user-activity delete-history-item'] = """
    type: command
    short-summary: "Delete navigation property historyItems for users."
"""

helps['crossdeviceexperiences user-activity list-history-item'] = """
    type: command
    short-summary: "Get historyItems from users."
"""

helps['crossdeviceexperiences user-activity show-history-item'] = """
    type: command
    short-summary: "Get historyItems from users."
"""

helps['crossdeviceexperiences user-activity update-history-item'] = """
    type: command
    short-summary: "Update the navigation property historyItems in users."
"""

helps['crossdeviceexperiences user-activity-history-item'] = """
    type: group
    short-summary: Manage user activity history item with crossdeviceexperiences_beta
"""

helps['crossdeviceexperiences user-activity-history-item delete-ref-activity'] = """
    type: command
    short-summary: "Delete ref of navigation property activity for users."
"""

helps['crossdeviceexperiences user-activity-history-item set-ref-activity'] = """
    type: command
    short-summary: "Update the ref of navigation property activity in users."
"""

helps['crossdeviceexperiences user-activity-history-item show-activity'] = """
    type: command
    short-summary: "Get activity from users."
"""

helps['crossdeviceexperiences user-activity-history-item show-ref-activity'] = """
    type: command
    short-summary: "Get ref of activity from users."
"""
