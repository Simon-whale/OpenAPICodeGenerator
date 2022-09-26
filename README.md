# Open API Code Generator

This project is used to learn / play with the OpenApi code contract Generators.  before you begin you need to install the following packages

## Important Nuget Packages
* NSwag.AspNetCore
* NSwag.Generation.AspNetCore
* Newtonsoft.Json

## Configuring NSwag

To configure NSwag you will need to create an [nswag.json](https://github.com/Simon-whale/OpenAPICodeGenerator/blob/master/Real_Learner/nswag.json) file.  You will need to make sure that you configure the following parts of the nswag.json file

* url (found in the DocumentGenerator section)
* namespace
* output (file location, where you want the output models / controllers or enums etc to be placed)

## Generating the file OpenApi C# files

**Option 1** To generate the files, you have two options, either to run the following command from the terminal

```
nswag run nswag.json  /runtime:Net60
```

**Option 2** is to add the following in your csproj file

```
    <Target Name="NSwag" BeforeTargets="BeforeCompile">
        <Exec WorkingDirectory="$(ProjectDir)" Command="nswag run nswag.json  /runtime:Net60" />
    </Target>
```

Everytime you then build the project it will look to see if you need to rebuild the the generated file

## Further reading

* [NSwag Configuration Document](https://github.com/RicoSuter/NSwag/wiki/NSwag-Configuration-Document)
* [Swagger Data Type](https://swagger.io/docs/specification/data-models/data-types/)
