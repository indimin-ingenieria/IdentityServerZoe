// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

#pragma warning disable 1591

namespace IdentityServerZoe.Extensions
{
    public static class IEnumerableExtensions
    {
        [DebuggerStepThrough]
        // cuando en una clase se hace uso del namespace Microsoft.IdentityModel.Tokens
        // y de este metodo de extension, se genera un error "ambiguous call" por otro metodo de ese paquete
        // ubicado en ColletionUtilities. Agrego el parametro ommitReferenceWhenConflictingCall con valor por defecto en true
        // para evitar el error. Este no tiene ningun uso salvo evitar el conflicto por lo que da igual el valor que tenga de momento
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> list, bool ommitReferenceWhenConflictingCall = true)
        {
            if (list == null)
            {
                return true;
            }
            
            if (!list.Any())
            {
                return true;
            }
            
            return false;
        }
        
        public static bool HasDuplicates<T, TProp>(this IEnumerable<T> list, Func<T, TProp> selector)
        {
            var d = new HashSet<TProp>();
            foreach (var t in list)
            {
                if (!d.Add(selector(t)))
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}