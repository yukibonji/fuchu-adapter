﻿module Filters

open System.IO
open System.Collections.Generic

let sourcesUsingFuchu (sources:IEnumerable<string>) =
    query
      {
        for source in sources do
        where ((Path.GetFileName(source) <> "Fuchu.VisualStudio.TestAdapter.dll") &&
               (File.Exists(Path.Combine(Path.GetDirectoryName(source), "Fuchu.dll"))))
      }
