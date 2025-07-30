using System.Collections.Generic;
using UnityEngine;

public interface INGUITextureProcessor
{
	void PrepareToProcess(List<Texture> textures);

	Texture Process(Texture src);
}
