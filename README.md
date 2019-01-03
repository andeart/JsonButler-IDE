# [![logo-v2-64-vs][jsonbutlervs icon]](#) JsonButler-IDE

`JsonButler-IDE` lets you use [JsonButler][jsonbutler library]'s features inside your Visual Studio environment, along with some additional features.

- Generate C# types from JSON snippets/files.
- Serialize C# types to JSON text, from within Visual Studio (project does not need to be running).
- Easily change cases of phrases (to camelCase, lower_snake_case, PascalCase, and _underscoreCamelCase).
- More features coming soon!

## Generate C# types from JSON snippets/files.
Convert your JSON snippets easily into C# types usable in code.<br/>
For example:<br/>
![json-source][jb-0-jsonsource]<br/>
automatically generates:
```csharp
namespace Andeart.CustomPayloads
{
    public class MyNewPayload
    {
        [JsonProperty ("name")]
        public string Name { get; private set; }

        [JsonProperty ("lines")]
        public string[] Lines { get; private set; }

        [JsonProperty ("winning_number")]
        public int WinningNumber { get; private set; }

        [JsonProperty ("new_type")]
        public NewType NewType { get; private set; }

        [JsonConstructor]
        private MyNewPayload (string name, string[] lines, int winningNumber, NewType newType)
        {
            Name = name;
            Lines = lines;
            WinningNumber = winningNumber;
            NewType = newType;
        }
    }

    public class NewType
    {
        [JsonProperty ("nested_type")]
        public NestedType NestedType { get; private set; }

        [JsonConstructor]
        private NewType (NestedType nestedType)
        {
            NestedType = nestedType;
        }
    }

    public class NestedType
    {
        [JsonProperty ("id")]
        public float Id { get; private set; }

        [JsonConstructor]
        private NestedType (float id)
        {
            Id = id;
        }
    }
}
```

## Serialize C# types to JSON text, from within Visual Studio

Convert your C# payload types into JSON, using default values as needed.<br/>
For example: <br/>
```csharp
public class HandleMaterial
{
    public int MaterialName { get; }

    public HandleMaterial (int materialName)
    {
        MaterialName = materialName;
    }
}


public class HandleData
{
    public float Strength { get; }

    public HandleMaterial Material { get; }

    [JsonIgnore]
    public Handle Handle { get; private set; }

    public HandleData (float strength, HandleMaterial material)
    {
        Strength = strength;
        Material = material;
    }
}
```
can be converted via the right-click context menu,
![ser-cs][jb-1-sercs]
to automatically generate this JSON snippet:
```json
{
  "strength": 0.0,
  "material": {
    "material_name": 0
  }
}
```



[jsonbutler library]: https://github.com/andeart/JsonButler "JsonButler"
[jsonbutlervs icon]: https://user-images.githubusercontent.com/6226493/44009167-a0dc8714-9e5e-11e8-93c9-802549e5187a.png "JsonButler"
[jb-0-jsonsource]: https://user-images.githubusercontent.com/6226493/45602176-51b4b900-b9ce-11e8-8607-54146b1dad3d.png "JsonButler"
[jb-1-sercs]: https://user-images.githubusercontent.com/6226493/45602343-5fb80900-b9d1-11e8-8add-733090a38b93.png "JsonButler"
