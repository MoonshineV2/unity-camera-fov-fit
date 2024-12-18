using UnityEngine;

namespace Gilzoide.CameraFit
{
    [AddComponentMenu("Camera FOV Fit/Renderer FOV Fitter")]
    public class RendererFovFitter : AFovFitter
    {
        [Tooltip("Renderer whose bounds will be used to fit the target Camera's FOV. If null, nothing will happen.")]
        [SerializeField] public Renderer _renderer;

        protected override Bounds? GetWorldBounds()
        {
            if (_renderer)
            {
                return _renderer.bounds;
            }
            else
            {
                return null;
            }
        }
    }
}
