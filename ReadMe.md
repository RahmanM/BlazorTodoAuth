# Issues of deploying the Identity Server To Azure

- Need to have a self signed certificate

$AzureWebsiteName = "https://blazortodoappwithauth.azurewebsites.net/"
$CertPassword = "somepassword" 
$PfxOutputLocation = "C:\temp\cert.pfx" # Folder must already exist

#### You shouldn't need to modify anything below this line.

$cert = New-SelfSignedCertificate -certstorelocation cert:\localmachine\my -dnsname $AzureWebsiteName

$pwd = ConvertTo-SecureString -String $CertPassword -Force -AsPlainText

$path = 'cert:\localMachine\my\' + $cert.thumbprint 
Export-PfxCertificate -cert $path -FilePath $PfxOutputLocation -Password $pwd


- Need to deploy the self singed certificate to Azure under TLS/Certificates
- Need to Get the Certificate Thumbnail (by clicking the certificate in Azure) and create an Environment Variable under
  Azure > Configurations
- Need to update the appsetting of the Server application to include the Certificate details

"IdentityServer": {
    "Clients": {
      "BlazorTodos.Client": {
        "Profile": "IdentityServerSPA",
        "Key": {
          "Type": "Store",
          "StoreName": "My",
          "StoreLocation": "CurrentUser",
          "Name": "CN=https://blazortodoappwithauth.azurewebsites.net/"
        }
      }
      
    }


- Add this into the startup file:
IdentityBuilder.AddSigningCredentials();
More readings here:

https://stackoverflow.com/questions/57246219/how-to-configure-key-settings-for-identityserver-in-appsettings-json-for-aspnet

and 

https://dev.to/seankilleen/solved-blazor-identityserver-500-30-error-ancm-issue-f7c


