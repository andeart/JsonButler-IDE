# [![logo-v2-64-vs][jsonbutlervs icon]](#) JsonButler-IDE

`JsonButler-IDE` lets you use [JsonButler][jsonbutler library]'s features inside your Visual Studio environment, along with some additional features.

- Generate C# types from JSON snippets/files.
- Serialize C# types to JSON text, from within Visual Studio (project does not need to be running).
- Easily change cases of phrases (to camelCase, lower_snake_case, PascalCase, and _underscoreCamelCase).
- More features coming soon!

## Generate C# types from JSON snippets/files.
Convert your JSON snippets easily into C# types usable in code.<br/>
For example:<br/>
![json-source][jb-0-jsonsource]
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





[jsonbutler library]: https://github.com/andeart/JsonButler "JsonButler"
[jsonbutlervs icon]: https://user-images.githubusercontent.com/6226493/44009167-a0dc8714-9e5e-11e8-93c9-802549e5187a.png "JsonButler"
[jb-0-jsonsource]: https://user-images.githubusercontent.com/6226493/45602176-51b4b900-b9ce-11e8-8607-54146b1dad3d.png
