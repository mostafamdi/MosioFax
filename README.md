# MosioFAX
MosioFAX is a Windows application that allows you to send faxes via Asterisk-based PBX systems such as Issabel, Elastix, and FreePBX, using HylaFAX in the backend.

# Features
- Send faxes via Asterisk-based PBX systems
- Monitor hylafax modems status
- Supports Issabel, Elastix, FreePBX
- Uses HylaFAX as fax server
- Simple and lightweight Windows GUI

# Installation
1. Download the latest release from the [Releases](https://github.com/mostafamdi/MosioFax/releases) section.
2. Extract the zip file.
3. Run `MSIOFAX-Send.sln`.
Make sure HylaFAX is installed and configured correctly on your server.

# Configuration
1. First, make sure you have created a **HylaFAX user** on your IP-PBX system and assigned a password to it.
2. Open **MosioFAX**, go to the **Settings** tab, and enter the following:
   - Server IP address
   - HylaFAX username
   - HylaFAX password  
   Then click **Save** to apply the settings.

# HylaFAX User Setup on PBX
Before using MosioFAX, you need to create a user in your PBX system for HylaFAX access:
1. Open the terminal/console of your PBX and run the following command to add a new user:
   ```bash
   #adduser user-name
   
2.Find the UID (User ID) of the new user by checking the /etc/group file:
#cat /etc/group

Look for a line like:
user-name:x:1001:

Here, 1001 is the UID you will use in the next step.
**#faxadduser -p your-password -u 1001 user-name**
Now your HylaFAX user is ready to be used in the MosioFAX application.
 










