﻿using System;
using System.Reflection.Emit;
using EmitMapperCore.AST.Interfaces;

namespace EmitMapperCore.AST.Nodes
{
    class AstInitializeLocalVariable: IAstNode
    {
        public Type localType;
        public int localIndex;

        public AstInitializeLocalVariable()
        {
        }

        public AstInitializeLocalVariable(LocalBuilder loc)
        {
            localType = loc.LocalType;
            localIndex = loc.LocalIndex;
        }

        public void Compile(CompilationContext context)
        {
            if(localType.IsValueType)
            {
                context.Emit(OpCodes.Ldloca, localIndex);
                context.Emit(OpCodes.Initobj, localType);
            }
        }
    }
}