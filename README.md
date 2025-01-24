Windows Service Bouncer (AKA OB Bouncer / Service Bouncer) is a simple utility designed to allow the user to target multiple Windows Services for repeated "Stop" and "Start" commands. 

This was created to assist developers and admins who often must restart services and/or sites to do iterative testing or troubleshooting. Instead of targeting each service individually, users can target multiple services and leave them selected for repeat "Stop" or "Start" commands, simplifying and expediting an otherwise tedious part of the process.

**SUPPORT**

This version of the Windows Service Bouncer is intended to be CPU and Win version agnostic, allowing it to run from servers or workstations.

This version of the Windows Service Bouncer targets services on the local machine only. Remote service control is not supported at this time.

This version of the Windows Service Bouncer supports logging via Event Viewer. To enable this functionality the utility MUST be "Run as Administrator" to have the necessary permissions to create Event Viewer sources and entries. If it is not "Run as Administrator", it is expected that permissions and errors related to them will prevent the Windows Service Bouncer from operating as expected. 

**SEARCH:**

Search field added to allow filtering down to specific values.

Search Example: Entering "Windows" and pressing "Search" should return a list of only the services running on the local machine that contain the text "Windows" (eliminating excess Windows services from criteria). 

**About**

Created by Matt Reid (Git: The-much-cooler-Matt-Reid), last updated Jan 2025.

Note: Not affiliated, endorsed, or associated with Microsoft, Windows, or other entities/applications interacted with. 
Use at your own risk. Design assumes user is knowledgable and capable about Windows Services and the impacts of stopping/starting them.
If concerned about the utility, submit the source code (available here) to your IT/IS Security for review and approval prior to use.
