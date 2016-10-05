# kaist-cs459
This repo is Kaist kaist CS492B class training doc - 20161011
Short URL : https://aka.ms/cs459

## Cloud and Microsoft Azure
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

```
// install ssh script for Node-RED  
// 백경덕 조교님  
```

By default, all VM inbound port is blocked, except SSH(port 22). To open another VM inbound port(ex. HTTP 80 port), process in Azure Portal "Network Security Group".  
Opening ports to a VM in Azure using the Azure Portal  
https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-windows-nsg-quickstart-portal/  
Opening ports to a VM in Azure using the Azure Classic Portal  
https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-windows-classic-setup-endpoints/  

## Azure IoT Hub

Azure IoT hub documentation  
https://azure.microsoft.com/en-us/documentation/services/iot-hub/  

Azure and Internet of Things  
https://azure.microsoft.com/en-us/documentation/articles/iot-hub-what-is-azure-iot/  

```
Get started with Azure IoT Hub for Node.js  
https://azure.microsoft.com/en-us/documentation/articles/iot-hub-node-node-getstarted/  

Get started with Azure IoT Hub for .NET  
https://azure.microsoft.com/en-us/documentation/articles/iot-hub-csharp-csharp-getstarted/  
```

## Technical community
Microsoft Forum category with "Microsoft Azure Platform"  
https://social.msdn.microsoft.com/Forums  

stackoverflow tag with "Azure"  
http://stackoverflow.com/questions/tagged/azure  