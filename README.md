# RemoteLogMaintenance
###Manages TShock Sever MySQL logs

Remote Log manager is a GUI tool to manage a TShock log data set when configured to use MySQL as the logging source. The option UseSqlLogs must be set to true to be able to use this command.

The Remote Log Manager is invoked by issuing the clicking on the windows executable file name RemoteLogMaintenance.exe

The permission LogManager.allow must be set to use this tool. 

Once the command is invoked, an interactive form will be displayed. The form is simplistic and options are invoked through command buttons.

The main functions allow the administrator to:

Search the log database for all entries based on a date/time and fuzzy content search.

  Select records to operate on.

  Delete selected records.

  Save selected records in a variety of formats such as 

    Text

    Cvs

Statistics about the size of the log will be given.

The installation of the Remote Log Maintenance program requires several steps.

First, the file SQLLoggerRest.dll must be placed in the TShock Server Plugins folder. A restart of the server will be required to load the dll.

Second, the files RemoteLogMaintenance.exe and Newtonsoft.Json.dll must be placed together in any location desired.

Third, ensure that the optionUseSqlLogs is set to true in the config.json file in the tshock folder on the server.

When the tool is first started, click on the Settings button near the top left to enter valid credentials to access the server via the RestAPI protocol. The RESTAPI funtionality must be turned on through the use of a configuration option. 

###Enable RESTAPI

To use the API first it must be enabled. You can enable it through the config.json file that is created by the TShock server.

To enable the REST API find the following lines in the config.json file (choose a port that is open to your TShock server):

"RestApiEnabled": false, "RestApiPort": 7878,

Change the "false" to "true" and restart the server.

####**Changelog**#
Version 2.0.1.17 is the starting platform for this tool. The dll is starting with version 2.0.1.17


####**Future**#
Suggestions are welcome.

####**Legal Stuff**#
Comments are always welcome. If you have a suggestion for an improvement please don't hesitate to contact me. The dll is offered as an open source project. Anyone may use this tool without asking for permission.
