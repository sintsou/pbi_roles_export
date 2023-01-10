# Export the list of roles with their conditions from Power BI report

The aim of this option is to export a list of roles and their conditions using Tabular Editor. 
The script is built on an existing [Metadata Export](https://github.com/m-kovalsky/Tabular/releases/) script.

## Steps

- Open the desired Power BI report using Power BI Desktop. 
- Launch Tabular Editor from the External Tools tab in Power BI. 
- In Tabular Editor, go to the "Advanced Scripting" tab. 
- Insert the script, change the destination folder (as per the "folderName" variable), and press the "Run script" button (or use the shortcut key F5).  
- Upon successful execution, a message "Script executed successfully. 0 model changes." will appear in the bottom-right corner. The results will be in the csv file in the defined folder.
