# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

- Added support for JMESPath queries #35
- Added clientId and tenantId parameters to the login command #40

### Changed

- Fixed bug caused by URL path parameters not being set in the request information object #38
- Fixed stream output being passed to output formatter when no file path is provided #38
- Format JSON output by default. A switch has been added to optionally turn off this behavior #55
- Use async OutputFormatter & OutputFilter APIs #55
