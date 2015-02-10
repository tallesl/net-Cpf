# Validador CPF

[![build](https://ci.appveyor.com/api/projects/status/github/tallesl/ValidacaoCPF)](https://ci.appveyor.com/project/TallesL/ValidacaoCPF)
[![nuget package](https://badge.fury.io/nu/ValidacaoCPF.png)](http://badge.fury.io/nu/ValidacaoCPF)

*Performs a digit check on Brazilian Individual Taxpayer Registry ([CPF](http://en.wikipedia.org/wiki/Cadastro_de_Pessoas_F%C3%ADsicas)).*

```cs
using ValidacaoCPF;

ValidadorCPF.Valido("29594421134"); // True
ValidadorCPF.Valido("488.081.131-91"); // True
ValidadorCpf.Valido("00000000000"); // False
ValidadorCpf.Valido("lol"); // False
```