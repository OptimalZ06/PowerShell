// Copyright 2018 (c) Nutanix. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the repository root for full license information.
// Purpose: Exception classes source for 'Nutanix.PowerShell.SDK'
// Author: Nutanix
// Copyright: Nutanix, 2018
// Owner: PowerShell@nutanix.com
// Maintainer(s):
//   Jon Kohler  (Nutanix, JonKohler)
//   Alex Guo    (Nutanix, mallochine)

using System;
using System.Runtime.Serialization;

namespace Nutanix.PowerShell.SDK
{
  [Serializable]
  public class NtnxException : Exception
  {
  [NonSerialized]
    private const string HelpLinkURL = "https://github.com/nutanix/PowerShell/issues";

    public NtnxException()
    {
      this.HelpLink = HelpLinkURL;
    }

    public NtnxException(string message) : base(message)
    {
      this.HelpLink = HelpLinkURL;
    }

    public NtnxException(string message, Exception innerException) : base(message, innerException)
    {
      this.HelpLink = HelpLinkURL;
    }

    protected NtnxException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
      this.HelpLink = HelpLinkURL;
    }
  }
}
