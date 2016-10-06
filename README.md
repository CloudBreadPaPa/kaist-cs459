# kaist-cs459
This repo is Kaist kaist CS459 class training doc - 20161011
Short URL : https://aka.ms/cs459

## Cloud and Microsoft Azure
Microsoft Azure is a cloud computing platform and infrastructure, created by Microsoft, for building, deploying and managing applications and services through a global network of Microsoft-managed and Microsoft partner hosted datacenters.

Overview presentation of Cloud and Microsoft Azure  
Microsoft Azure : https://azure.microsoft.com

## Azure Portal
The Microsoft Azure portal is a central place where you can provision and manage your Azure resources.  
Azure new portal : https://portal.azure.com/  
Azure classic portal : https://manage.windowsazure.com  
Microsoft Azure portal overview  
https://azure.microsoft.com/en-us/documentation/articles/azure-portal-overview/

## Azure VM sizes
This article describes the available sizes and options for the Azure virtual machines you can use to run your Windows apps and workloads.  
Sizes for virtual machines in Azure  
https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-windows-sizes/

## Azure pricing & usage management
Estimate your expected monthly bill using our Pricing Calculator, and track your actual account usage and bill at any time using the billing portal.  
https://azure.microsoft.com/en-us/pricing/

## Azure Linux VM creation for Node-RED
This link shows you how to use the Azure portal to create a Linux Virtual Machine quickly. The only requirements are an Azure account and SSH public and private key files.  

Create a Linux VM on Azure using the Portal  
https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-linux-quick-create-portal/  

Appendix :  
Create a virtual machine running Windows in the Azure classic portal  
https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-windows-classic-tutorial/  
How to set up endpoints on a classic Windows virtual machine in Azure  
https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-windows-classic-setup-endpoints/

## SSH key creation
With an SSH keypair you can create Virtual Machines on Azure that default to using SSH keys for authentication, eliminating the need for passwords to log in.  
Create SSH keys on Linux and Mac for Linux VMs in Azure  
https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-linux-mac-create-ssh-keys/

## Reset SSH access
Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess Extension  
https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-linux-using-vmaccess-extension/

## Install Node-RED
Node-RED is a tool for wiring together hardware devices, APIs and online services in new and interesting ways.  
http://nodered.org/  

Node-red is based on node.js -> install node.js first.
https://nodejs.org/en/download/

Install node-red by following command:
sudo npm install -g --unsafe-perm node-red
```
sudo apt-get update  
sudo apt-get install nodejs  
sudo apt-get install npm  
```
```
// install node-red
sudo npm install -g --unsafe-perm node-red  
```

By default, all VM inbound port is blocked, except SSH(port 22). To open another VM inbound port(ex. HTTP 80 port, Node-red 1880 port), process in Azure Portal "Network Security Group".  
Opening ports to a VM in Azure using the Azure Portal  
https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-windows-nsg-quickstart-portal/  
Opening ports to a VM in Azure using the Azure Classic Portal  
https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-windows-classic-setup-endpoints/  

## Azure IoT Hub

Azure IoT hub documentation  
https://azure.microsoft.com/en-us/documentation/services/iot-hub/  

Azure and Internet of Things  
https://azure.microsoft.com/en-us/documentation/articles/iot-hub-what-is-azure-iot/  

### IoT Mission  
Build your own real-world IoT solution to receive data from device to IoT cloud data storage in 60 min.
- Simulated IoT device  
- Send JSON data to Azure IoT hub  
- Process realtime IoT data in Stream Analytics
- Store JSON data in Azure blob storage

#### common hands-on, deploy Azure services for IoT
1. Log on to Azure Portal - https://portal.azure.com/  
2. Click new - type "resource group" - create - type name and change location to "Japan West"  
3. Click new - internet of things - IoT hub click - type name - change Resource group to just created - click create button  
4. Click new - internet of things - Stream analytics Job - type job name and change Resource group to just created - click create button  
5. Click new - sStorage - Storage account - type name - change Replication to "Locally-redundant storage(LRS)" and change Resource group to just created - click create button  
6. click IoT Hub - "Shared access policy" - iothubowner - copy "connection string primary key". This is used in your app as connectionstring value.  

==You can choice your prefer language between node.js and C# to simulate IoT device==  

#### node.js hands-on coding
```
// Fork and clone https://github.com/CloudBreadPaPa/kaist-cs459 repository.
// Open kaist-cs459\node\createdeviceidentity folder CreateDeviceIdentity.js file
// Change below connection string code value as yours
...
var connectionString = 'HostName=something.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=somgthing';
...
device.deviceId = 'kaist-device-00';
...
```

```
//Execute CreateDeviceIdentity.js app to generate device key
node CreateDeviceIdentity.js
```

```
// Open kaist-cs459\node\simulateddevice folder SimulatedDevice.js file
// Change below code
...
var connectionString = 'HostName=something.azure-devices.net;DeviceId=kaist-device-00;SharedAccessKey=generated-device-key';
...
```
```
//Execute SimulatedDevice.js app send IoT message to IoT Hub
node SimulatedDevice.js
```

#### C# hands-on coding
```
// Fork and clone https://github.com/CloudBreadPaPa/kaist-cs459 repository.
// open kaist-cs459\cs\cs459-iot folder, cs459-iot.sln Visual Studio solution file
// CreateDeviceIdentity project - Program.cs file
// Change below code to your connection string
...
static string connectionString = "HostName=something.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=something";
...
string deviceId = "dw-kaist-device00";
...
```
Execute project and generate device Key
```
// open SimulatedDevice project - Program.cs file
// change below code
...
static string iotHubUri = "something.azure-devices.net";
static string deviceKey = "generated-device-key";
...
deviceClient = DeviceClient.Create(iotHubUri, new DeviceAuthenticationWithRegistrySymmetricKey("dw-kaist-device00", deviceKey));
...
```
execute project to simulate IoT device.

#### common hands-on, set "Stream Analytics Job"
Go to Azure Portal - Reource Group - click your scream analytics - inputs - add - type name "input" and select "IoT Hub".   
Azure automatically populate IoT hub information and set it as input - click save   
Click outputs - add - type name "output" - Change Sink to "Blob storage" - select Storage account just created - click "create" button   
In Stream Analytics - overview - click Start button on the top - start it now   
Check output blob file.

#### Reference
Get started with Azure IoT Hub for Node.js  
https://azure.microsoft.com/en-us/documentation/articles/iot-hub-node-node-getstarted/  

Get started with Azure IoT Hub for .NET  
https://azure.microsoft.com/en-us/documentation/articles/iot-hub-csharp-csharp-getstarted/  

Get started with Azure Stream Analytics to process data from IoT devices
https://azure.microsoft.com/en-us/documentation/articles/stream-analytics-get-started-with-azure-stream-analytics-to-process-data-from-iot-devices/

Stream Analytics outputs: Options for storage, analysis
https://azure.microsoft.com/en-us/documentation/articles/stream-analytics-define-outputs/#blob-storage


## Technical community
Microsoft Forum category with "Microsoft Azure Platform"  
https://social.msdn.microsoft.com/Forums  

stackoverflow tag with "Azure"  
http://stackoverflow.com/questions/tagged/azure  
