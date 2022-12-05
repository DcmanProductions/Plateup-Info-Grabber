﻿namespace ShaderTextRestorer.ShaderBlob.Parameters
{
	public sealed class BufferBinding
	{
		public BufferBinding() { }

		public BufferBinding(string name, int index)
		{
			Name = name;
			NameIndex = -1;
			Index = index;
			ArraySize = 0;
		}

		public string Name { get; set; } = string.Empty;
		public int NameIndex { get; set; }
		public int Index { get; set; }
		public int ArraySize { get; set; }
	}
}
