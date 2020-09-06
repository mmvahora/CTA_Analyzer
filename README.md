# CTA "L" Analyzer

## Background 
The Chicago CTA trains, also known as the "L" (for elevated), is an expansive mass public transit system which connects millions of Chicagoland residents. The system is made up of many train stations, all connected via train lines. Each of these stations have varying ridership, connections, directions and accessibility. 

Ridership data for the entire system is logged and stored in a CTA.mdf SQL relational database. The relational database is made up of 5 tables:

*  Stations
* Stops
*StopDetails 
*Lines
*Ridership

Here’s the ER (Entity Relationship) schema shown below:

![alt text](https://i.imgur.com/kPu4FzF.jpg)

## Application
Written entirely in C# and developed in Visual Studio, the application reads the CTA.mdf file and builds a local mySQL database server. Using various SQL queries, we can build and display a GUI of all the relations between stations/lines, accessibility, direction, location, and various ridership statistics. Also included is a list of the top 10 stations based on total ridership. 

To run, open project solution is Visual Studio and run, or simply run the provided  CTA_Analyzer application/executable located in /Bin/Debug.  

Once the GUI displays, from the drop-down menu click File->Load. 

The application should now be running and displaying as such:

![alt text](https://i.imgur.com/A2EeKhe.jpg)
