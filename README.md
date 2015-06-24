<p align="center">
    <a href="#validador-cpf">
        <img alt="logo" src="logo/200x160.png">
    </a>
</p>

# Validador CPF

[![build](https://ci.appveyor.com/api/projects/status/ryvx5c1l0pgoesn9)](https://ci.appveyor.com/project/TallesL/validadorcpf)
[![nuget package](https://badge.fury.io/nu/ValidadorCPF.png)](http://badge.fury.io/nu/ValidadorCPF)

*Performs a digit check on Brazilian Individual Taxpayer Registry ([CPF](http://en.wikipedia.org/wiki/Cadastro_de_Pessoas_F%C3%ADsicas)).*

```cs
using ValidacaoCPF;

ValidadorCPF.Valido("29594421134"); // True
ValidadorCPF.Valido("488.081.131-91"); // True
ValidadorCpf.Valido("00000000000"); // False
ValidadorCpf.Valido("lol"); // False
```
