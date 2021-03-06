# Joveler.Compression.ZLib

[zlib](https://zlib.net/) pinvoke library for .NET.

`DefalteStream` and its familiy is based on the code of [zlibnet](https://zlibnet.codeplex.com) by [@hardon](https://www.codeplex.com/site/users/view/hardon).

## Install

Joveler.Compression.ZLib can be installed via [nuget](https://www.nuget.org/packages/Joveler.Compression.ZLib/).

[![NuGet](https://buildstats.info/nuget/Joveler.Compression.ZLib)](https://www.nuget.org/packages/Joveler.Compression.ZLib)

## Features

- ZLibStream, the stream implementation conforms [RFC 1950](https://www.ietf.org/rfc/rfc1950.txt)
- Improved DeflateStream and GZipStream, conforming [RFC 1951](https://www.ietf.org/rfc/rfc1951.txt) and [RFC 1952](https://www.ietf.org/rfc/rfc1952.txt)
- Adler32 and CRC32 checksum

## Support

### Targeted .NET platforms

- .NET Standard 2.1 (.NET Core 3.0+)
- .NET Standard 2.0 (.NET Framework 4.6.1+, .NET Core 2.0+)
- .NET Framework 4.5.1

If you need .NET Framework 4.5 support, use [ZLibWrapper](https://www.nuget.org/packages/Joveler.ZLibWrapper) instead.  
If you need .NET Standard 1.3 support, use [v2.1.2](https://www.nuget.org/packages/Joveler.Compression.ZLib/2.1.2) instead.

### Supported OS platforms

| Platform | Architecture | Tested |
|----------|--------------|--------|
| Windows  | x86          | Yes    |
|          | x64          | Yes    |
| Linux    | x64          | Yes    |
|          | armhf        | Yes    |
|          | arm64        | Yes    |
| macOS    | x64          | Yes    |

#### Tested linux distributions

| Architecture  | Distribution | Note |
|---------------|--------------|------|
| x64           | Ubuntu 18.04 | Tested on AppVeyor CI         |
| armhf         | Debian 10    | Emulated on QEMU's virt board |
| arm64         | Debian 10    | Emulated on QEMU's virt board |

### Supported zlib version

- 1.2.11 (Included)

## Changelog

See [CHANGELOG.md](./CHANGELOG.md).

## Usage

See [USAGE.md](./USAGE.md).

## License

`Joveler.Compression.ZLib` is licensed under [zlib license](./LICENSE).
