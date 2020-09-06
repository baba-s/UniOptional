# UniOptional

無効値を表す構造体

## 使用例

```cs
using Kogane;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    private static Optional<string> GetName()
    {
        return default;
    }

    private void Start()
    {
        var name = GetName();

        // 値を持っている場合
        if ( name )
        {
            Debug.Log( name );
        }
        // 無効値の場合
        else
        {
            Debug.Log( "無効値" );
        }

        // 値を取得、無効値の場合はデフォルト値を取得
        Debug.Log( name.GetOrDefault() );
        
        // 値を取得、無効値の場合は引数に渡した値を取得
        Debug.Log( name.GetOrDefault( "無効値" ) );

        // 暗黙的なキャスト
        string str = name;
        
        // 暗黙的なキャスト
        name = "ピカチュウ";
    }
}
```
