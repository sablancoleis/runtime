// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace Microsoft.Diagnostics.DataContractReader.Contracts;

public interface IRuntimeMutableTypeSystem : IContract
{
    static string IContract.Name { get; } = nameof(IRuntimeMutableTypeSystem);

    IEnumerable<TargetPointer> EnumerateAddedFieldDescs(TypeHandle typeHandle, bool staticFields)
        => throw new NotImplementedException();

    bool IsFieldDescEnCNew(TargetPointer fieldDescPointer) => throw new NotImplementedException();

    /// <summary>
    /// Returns whether the given EnCFieldDesc still needs fixup (i.e., it hasn't been properly initialized yet).
    /// </summary>
    bool DoesEnCFieldDescNeedFixup(TargetPointer encFieldDescPointer) => throw new NotImplementedException();

    /// <summary>
    /// Gets the static field data address for an EnCFieldDesc.
    /// Returns TargetPointer.Null if the field data has not been allocated yet.
    /// </summary>
    TargetPointer GetEnCStaticFieldDataAddress(TargetPointer encFieldDescPointer) => throw new NotImplementedException();

    /// <summary>
    /// Gets the instance field data address for an EnC-added instance field hanging off the given object's SyncBlock.
    /// Returns TargetPointer.Null if the field has not been accessed yet.
    /// </summary>
    TargetPointer GetEnCInstanceFieldAddress(TargetPointer objectAddress, TargetPointer encFieldDescPointer) => throw new NotImplementedException();
}

public readonly struct RuntimeMutableTypeSystem : IRuntimeMutableTypeSystem
{
    // Everything throws NotImplementedException
}
