
# UPDATE #
Development of the library has been stopped. The official libraries for Windows  8.1 are going to be released
soon.
## Azure Managment Library for Windows 8 ##

## What is it? ##

You can write a client app on Windows 8 or Windows 8.1 to manage your Azure subscriptions, without the pain of using the Azure Management REST-API directly.

## Why? ##

Because I started to work on an Azure management client for Windows 8.1.


## How to use ##

The client is written to be used with PFX file descriptions that are imported from existing PFX certificate files, and imported into the certificate store of your WinRT app.

To do so, you simply create a FileOpenPicker:

          var filePicker = new FileOpenPicker();
            filePicker.FileTypeFilter.Add(".pfx");
            filePicker.FileTypeFilter.Add(".PFX");
            filePicker.ViewMode = PickerViewMode.List;
            filePicker.SuggestedStartLocation = PickerLocationId.ComputerFolder;
            filePicker.SettingsIdentifier = "picker1";
            filePicker.CommitButtonText = "Open PFX file";

			var file = await filePicker.PickSingleFileAsync();

Create new CertificateCredentials. Pass the file to the constructor of the CertificateCredentials class. Then call the IntializeCredentials method of the CertificateCredentials client. Pass a string as identifier (this value replaces the friendly name of the pfx description) and the password you used to export your PFX file using certmgr on Windows:

     CertificateCredentials creds = new CertificateCredentials(file);

            var success = await creds.InitializeCredentials("[YOUR IDENTIFIER]", "[YOUR PFX PASSWORD]");

            
            if(success.Successfull)
            {
                StorageClient cl = new StorageClient("[YOUR SUBSCRIPTION ID]");
                                             
                var storageServices = await cl.ListAsync();

                if(storageServices.Successfull)
                {
					//Do something here with the data
                }

            }

Then you create a client for the Azure services you want to work with. Currently there are the following clients available (list will be updated):

- StorageClient

After creating the client, you choose the operation, in the code-sample it is the ListAsync() operation, that lists all the storage services available in your subscription.

You can contact me on Twitter: [@awsomedevsigner](https://twitter.com/AWSOMEDEVSIGNER "@awsomedevsigner")

