//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v1.3.0.12
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace QuickArchive.Data.Db
{
   public partial class Keyword
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Keyword()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="id"></param>
      /// <param name="name"></param>
      public Keyword(Guid id, string name)
      {
         this.Id = id;

         if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
         this.Name = name;


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="id"></param>
      /// <param name="name"></param>
      public static Keyword Create(Guid id, string name)
      {
         return new Keyword(id, name);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Id
      /// </summary>
      internal Guid _Id;
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before setting.
      /// </summary>
      partial void SetId(Guid oldValue, ref Guid newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before returning.
      /// </summary>
      partial void GetId(ref Guid result);

      /// <summary>
      /// Identity, Indexed, Required
      /// </summary>
      [Key]
      [Required]
      public Guid Id
      {
         get
         {
            Guid value = _Id;
            GetId(ref value);
            return (_Id = value);
         }
         set
         {
            Guid oldValue = _Id;
            SetId(oldValue, ref value);
            if (oldValue != value)
            {
               _Id = value;
            }
         }
      }

      /// <summary>
      /// Backing field for Name
      /// </summary>
      internal string _Name;
      /// <summary>
      /// When provided in a partial class, allows value of Name to be changed before setting.
      /// </summary>
      partial void SetName(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Name to be changed before returning.
      /// </summary>
      partial void GetName(ref string result);

      /// <summary>
      /// Indexed, Required, Max length = 255
      /// </summary>
      [Required]
      [MaxLength(255)]
      [StringLength(255)]
      public string Name
      {
         get
         {
            string value = _Name;
            GetName(ref value);
            return (_Name = value);
         }
         set
         {
            string oldValue = _Name;
            SetName(oldValue, ref value);
            if (oldValue != value)
            {
               _Name = value;
            }
         }
      }

   }
}

