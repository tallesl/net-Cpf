<p align="center">
    <a href="#cpf">
        <img alt="logo" src="Assets/logo.png">
    </a>
</p>

# Cpf

[![][build-img]][build]
[![][nuget-img]][nuget]

Digit check and formatting on Brazilian Individual Taxpayer Registry ([CPF]).

[build]:     https://ci.appveyor.com/project/TallesL/net-Cpf
[build-img]: https://ci.appveyor.com/api/projects/status/github/tallesl/net-Cpf?svg=true
[nuget]:     https://www.nuget.org/packages/Cpf
[nuget-img]: https://badge.fury.io/nu/Cpf.svg
[CPF]:       http://en.wikipedia.org/wiki/Cadastro_de_Pessoas_F%C3%ADsicas

## Usage

```cs
using CpfLibrary;

Cpf.Check("29594421134");    // True
Cpf.Check("488.081.131-91"); // True
Cpf.Check("00000000000");    // False
Cpf.Check("lol");            // False

Cpf.Format("29594421134"); // "295.944.211-34"
Cpf.Format("lol");         // "lol"
```
