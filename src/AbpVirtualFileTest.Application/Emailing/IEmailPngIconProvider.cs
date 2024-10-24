using System;
using System.Linq;
using System.Text;

namespace AbpVirtualFileTest.Emailing;

public interface IEmailPngIconProvider : IEmailIconProvider, IIconManifestGenerator
{ }
