using System.Collections;
using UnityEngine;

namespace Ball
{
    public interface ILocalPositionAdapter
    {
        Vector3 LocalPosition { get; set; }
    }
}