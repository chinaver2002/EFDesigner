//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Testing
{
   public abstract partial class HiddenEntity
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public HiddenEntity()
      {

         Init();
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      public int Id { get; set; }

   }
}

