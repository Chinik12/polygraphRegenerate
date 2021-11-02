# polygraphRegenerate
You can regenerate, or change, the PolyLama NFT. If you have one NFT of [PolyLama Project](https://opensea.io/collection/polylama) you can read the raw data and use it for create your image.



# How to Build 

In root folder

```
dotnet restore .\polygraph.sln
dotnet build .\polygraph.sln

dotnet publish .\src\polygraphRegenerate\polygraphRegenerate.csproj -o <YouPathOutput>
```

# How to use

If you have a PolyLama form [PolyLama Project](https://opensea.io/collection/polylama), you can access to unlockable content.

![](/repository/image01.png)

Copy the unlockable content into a file, like exmple.json

![](/repository/image02.png)


Now you can call the program with the file path as argument

```
polygraphRegenerate.exe -f D:\temp\example.json
```

and you can have "image#00001.png", a PolyLama in Black Background.

![](/repository/image03.png)
