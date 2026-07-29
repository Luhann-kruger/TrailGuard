TrailGuard

TrailGuard is a Windows desktop application that helps national parks manage hiking trails and permits. It also helps park staff keep track of hikers, emergency contacts, and any incidents that happen during hikes.

Features

Admin Features
      View all trails in different parks
      Open or close a trail
      Edit trail information such as:
      Trail name
      Difficulty level (1–5)
      Maximum number of hikers
      Assigned park
Main Features
      Create hiking permits
      Record check-in and expected return times
      Add incident reports for active permits
      Store hiker information, including medical notes and emergency contacts
      Allow one permit to include multiple hikers for group hikes

Technology Used
      Language: C#
      Framework: Windows Forms (.NET)
      Database: SQL Server Express LocalDB
     

The project uses seven tables:

Table	                  Purpose
Park	                  Stores information about national parks.
Trail	                  Stores trail details and links each trail to a park.
Permit	                Stores hiking permit information.
Participant	            Stores hiker information.
EmergencyContact	      Stores emergency contacts for hikers.
Permit_Participant	    Connects permits with one or more hikers.
IncidentReport	        Stores incidents linked to a permit.


Getting Started

Requirements
Visual Studio 2022 (or newer)
SQL Server Express LocalDB
