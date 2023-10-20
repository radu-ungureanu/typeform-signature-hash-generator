# typeform-signature-hash-generator
Generate the Typform's SignatureHash based on the request's payload

# Publishing the tool

``` bash
cd src
dotnet publish .\TypeformSignatureGenerator\TypeformSignatureGenerator.csproj --configuration Release --self-contained true --runtime win-x64 --output ./dist
```
