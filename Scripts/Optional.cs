using System;
using UnityEngine;

namespace Kogane
{
	[Serializable]
	public struct Optional<T>
	{
		[SerializeField] private bool m_hasValue;
		[SerializeField] private T    m_value;

		public bool HasValue => m_hasValue;

		public T Value
		{
			get
			{
				if ( HasValue ) return m_value;
				throw new InvalidOperationException();
			}
		}

		public Optional( T value = default )
		{
			m_value    = value;
			m_hasValue = true;
		}

		public T GetOrDefault()
		{
			return GetOrDefault( default );
		}

		public T GetOrDefault( T defaultValue )
		{
			return HasValue ? m_value : defaultValue;
		}

		public static implicit operator T( Optional<T> optional )
		{
			return optional.Value;
		}

		public static implicit operator Optional<T>( T value )
		{
			return new Optional<T>( value );
		}

		public static implicit operator bool( Optional<T> optional )
		{
			return optional.HasValue;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson( this, true );
		}
	}
}