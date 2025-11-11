# DNPM:DIP MTB Data-Transfer-Objects for .NET

Serialization and deserialization of DNPM:DIP MTB DTOs for .NET using the C# programming language.

This crate provides DNPM:DIP data model for use with "Modellvorhaben gem. §64e SGB V"

## Usage notices

This library uses `NewtonSoft.Json` to handle JSON strings.

JSON (de)serialization includes format conversion for patients birthdate and date of death as introduced in
https://github.com/dnpm-dip/backend-core/commit/97c44aa8bbd6ba4ac81824c5178db23fd08f9068