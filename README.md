# SKB.Core.ProjectTemplates
A consistent provisioning of Project Templates plays an important role 
when it comes to the development efficiency as well as code consistency and quality.

A consistent code is always easily maintainable, requiring less refactoring. 
This proves to be an important asset for a competent architect.

This project provides us the standard, baseline templates for the projects which are 
to be managed (currently) on following aspects:
1. Code Style and Quality:
   This is maintained and promised by provisioning of consistent project structure, solution
    structure and a well crafted ``.editorconfig``. Inclusion of ``.editorconfig`` is promised 
    before build time by ``SKB.Core.EditorConfig`` and managed Centrally.
2. Licenses:
    It may be possible that the licenses in a set of projects can differ, causing issue with 
   audit time inconsistencies. These are rectified by ``SKB.Core.LicenseConfig``. This is also 
   centrally managed with the Nuget Package Versioning.


## Getting Started
### As Prerequisites, follow these steps:
1. Make sure you are connected to the network
2. Make sure you are breathing
3. Make sure you are well-hydrated

Once Prerequisites are satisfied, add following source to your nuget feed:
```shell
dotnet nuget add source --username <username> --password <pat-token> \
  --name SKB.NuGet https://nuget.pkg.github.com/saapo-ka-baadshah/index.json
```
These maintainance packages are part of:
https://github.com/saapo-ka-baadshah/SKB.Core.ProjectFixtures/tree/main

You can check the sources and create your own nuget feed for such.