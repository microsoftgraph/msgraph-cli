# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
### Added
- Add item sub-command for indexer paths (paths with id). `GET /users/{user-id}` changes from `mgc users get --user-id` to `mgc users item get --user-id`

### Changed
- Login command scopes are now optional
- Fix issue with nullable boolean options

## [0.1.0-preview.4] - 2022-04-19

### Added
- Add default app id & tenant id
- Add documented headers as command options

### Changed
- Make app settings configuration file optional

## [0.1.0-preview.3] - 2022-03-17

### Added

- Added support for JMESPath queries #35
- Added clientId and tenantId parameters to the login command #40

### Changed

- Fixed bug caused by URL path parameters not being set in the request information object #38
- Fixed stream output being passed to output formatter when no file path is provided #38
- Format JSON output by default. The formatting can be disabled per command through the CLI argument `--json-no-indent` #55
- Use async OutputFormatter & OutputFilter APIs #55
- Fix failing requests when adding options like `--select`, `--expand`, `--top` etc
