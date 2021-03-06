﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmitMapperCore.MappingConfiguration.MappingOperations
{
	interface IReadWriteOperation : IDestWriteOperation, ISrcReadOperation
	{
        Delegate NullSubstitutor { get; set; } // generic type: NullSubstitutor
        Delegate TargetConstructor { get; set; } // generic type: TargetConstructor
		Delegate Converter { get; set; }
		Delegate DestinationFilter { get; set; }
		Delegate SourceFilter { get; set; }
	}
}
