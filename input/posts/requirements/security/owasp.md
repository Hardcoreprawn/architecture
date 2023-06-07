---
Title: OWASP ASVS
Lead: The OWASP Application Security Verification Standard (ASVS) Project provides a basis for testing web application technical security controls and also provides developers with a list of requirements for secure development
Description: The OWASP ASVS project provides developers with a list of requirements for secure development and testable security controls.
Published: 27/04/2023
Draft: false
Tags:
  - Architecture
  - Requirements
  - Security
---
The OWASP ASVS standard provides a basis for testing application technical security controls and any technical security controls in the environment that are relied on to protect against vulnerabilities such as Cross-Site Scripting (XSS) and SQL injection. Use this to establish confidence in the security of Web applications.

The Roadmap for version 5 of the OWASP ASVS is available here: <https://github.com/OWASP/ASVS/wiki/Roadmap-to-version-5.0>

## Requirements

Consider the following controls for every application:

1. [Architecture, Design, and Threat Modelling](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x10-V1-Architecture.md)
2. [Authentication](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x11-V2-Authentication.md)
3. [Session management](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x12-V3-Session-management.md)
4. [Access Control](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x12-V4-Access-Control.md)
5. [Input Validation, Output Encoding, and Parameterization](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x13-V5-Validation-Sanitization-Encoding.md)
6. [Cryptography at Rest](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x14-V6-Cryptography.md)
7. [Error Handling and Logging](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x15-V7-Error-Logging.md)
8. [Data Protection in Transit](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x16-V8-Data-Protection.md)
9. [Secure Communication](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x17-V9-Communications.md)
10. [Malicious Code](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x18-V10-Malicious.md)
11. [Business Logic](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x19-V11-BusLogic.md)
12. [Files and Resources](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x20-V12-Files-Resources.md)
13. [API and Web Service](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x21-V13-API.md)
14. [Configuration](https://github.com/OWASP/ASVS/blob/v4.0.3/4.0/en/0x22-V14-Config.md)

## Audience

Collated for the following audiences:

  1. System designers and software engineers
  2. IT Professionals and operational engineers

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

The primary aim of the OWASP Application Security Verification Standard (ASVS) Project is to normalize the range in the coverage and level of rigor available in the market when it comes to performing application security verification using a commercially-workable open standard. [This standard can be used to establish a level of confidence in the security of web applications and services](https://owasp.org/www-pdf-archive/OWASP_ASVS_Standard_2008.pdf). The OWASP ASVS Project provides developers with a [list of requirements for secure development](https://owasp.org/www-project-application-security-verification-standard/). Developers can use this standard to ensure their applications are safe and meet industry security standards.

## References

1. OWASP V4.0.3 Stable release, 27/04/2023. <https://github.com/OWASP/ASVS/tree/v4.0.3/4.0>
2. OWASP Application Security Verification Standard, 27/04/2023. <https://owasp.org/www-project-application-security-verification-standard/>
