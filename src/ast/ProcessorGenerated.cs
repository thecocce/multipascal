// ---------------------------------------------------------------------
// Base Processor class, auto-generated									
// 	Do NOT edit this file												
// 	Additional methods should be defined in another file				
// ---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using crosspascal.ast.nodes;

namespace crosspascal.ast
{
	public abstract partial class Processor
	{
		//	Complete interface to be implemented by any specific AST processor	

		public virtual bool Visit(Node node)
		{
			return true;
		}
		
		public virtual bool Visit(FixmeNode node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(NotSupportedNode node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(EmptyNode node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(NodeList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(StatementList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(TypeList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(IntegralTypeList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(IdentifierList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(DeclarationList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(EnumValueList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(ParameterList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(FieldList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(CompilationUnit node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(ProgramNode node)
		{
			Visit((CompilationUnit) node);
			traverse(node.body);
			traverse(node.uses);
			return true;
		}
		
		public virtual bool Visit(LibraryNode node)
		{
			Visit((CompilationUnit) node);
			traverse(node.body);
			traverse(node.uses);
			return true;
		}
		
		public virtual bool Visit(UnitNode node)
		{
			Visit((CompilationUnit) node);
			traverse(node.interfce);
			traverse(node.implementation);
			traverse(node.init);
			return true;
		}
		
		public virtual bool Visit(PackageNode node)
		{
			Visit((CompilationUnit) node);
			traverse(node.requires);
			traverse(node.contains);
			return true;
		}
		
		public virtual bool Visit(UnitItem node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(UsesItem node)
		{
			Visit((UnitItem) node);
			return true;
		}
		
		public virtual bool Visit(RequiresItem node)
		{
			Visit((UnitItem) node);
			return true;
		}
		
		public virtual bool Visit(ContainsItem node)
		{
			Visit((UnitItem) node);
			return true;
		}
		
		public virtual bool Visit(ExportItem node)
		{
			Visit((UnitItem) node);
			return true;
		}
		
		public virtual bool Visit(Section node)
		{
			Visit((Node) node);
			traverse(node.decls);
			return true;
		}
		
		public virtual bool Visit(CodeSection node)
		{
			Visit((Section) node);
			traverse(node.block);
			return true;
		}
		
		public virtual bool Visit(ProgramBody node)
		{
			Visit((CodeSection) node);
			return true;
		}
		
		public virtual bool Visit(RoutineBody node)
		{
			Visit((CodeSection) node);
			return true;
		}
		
		public virtual bool Visit(InitializationSection node)
		{
			Visit((CodeSection) node);
			return true;
		}
		
		public virtual bool Visit(FinalizationSection node)
		{
			Visit((CodeSection) node);
			return true;
		}
		
		public virtual bool Visit(DeclarationSection node)
		{
			Visit((Section) node);
			traverse(node.uses);
			return true;
		}
		
		public virtual bool Visit(InterfaceSection node)
		{
			Visit((DeclarationSection) node);
			return true;
		}
		
		public virtual bool Visit(ImplementationSection node)
		{
			Visit((DeclarationSection) node);
			return true;
		}
		
		public virtual bool Visit(AssemblerRoutineBody node)
		{
			Visit((RoutineBody) node);
			return true;
		}
		
		public virtual bool Visit(Declaration node)
		{
			Visit((Node) node);
			traverse(node.type);
			return true;
		}
		
		public virtual bool Visit(LabelDeclaration node)
		{
			Visit((Declaration) node);
			return true;
		}
		
		public virtual bool Visit(ValueDeclaration node)
		{
			Visit((Declaration) node);
			return true;
		}
		
		public virtual bool Visit(VarDeclaration node)
		{
			Visit((ValueDeclaration) node);
			traverse(node.init);
			return true;
		}
		
		public virtual bool Visit(ParameterDeclaration node)
		{
			Visit((ValueDeclaration) node);
			traverse(node.init);
			return true;
		}
		
		public virtual bool Visit(VarParameterDeclaration node)
		{
			Visit((ParameterDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(ConstParameterDeclaration node)
		{
			Visit((ParameterDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(OutParameterDeclaration node)
		{
			Visit((ParameterDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(FieldDeclaration node)
		{
			Visit((ValueDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(ConstDeclaration node)
		{
			Visit((ValueDeclaration) node);
			traverse(node.init);
			return true;
		}
		
		public virtual bool Visit(EnumValue node)
		{
			Visit((ConstDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(TypeDeclaration node)
		{
			Visit((Declaration) node);
			return true;
		}
		
		public virtual bool Visit(CallableDeclaration node)
		{
			Visit((TypeDeclaration) node);
			traverse(node.Type);
			traverse(node.Directives);
			return true;
		}
		
		public virtual bool Visit(ProceduralType node)
		{
			Visit((TypeNode) node);
			return true;
		}
		
		public virtual bool Visit(MethodType node)
		{
			Visit((ProceduralType) node);
			return true;
		}
		
		public virtual bool Visit(RoutineDeclaration node)
		{
			Visit((CallableDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(MethodDeclaration node)
		{
			Visit((CallableDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(SpecialMethodDeclaration node)
		{
			Visit((MethodDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(ConstructorDeclaration node)
		{
			Visit((SpecialMethodDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(DestructorDeclaration node)
		{
			Visit((SpecialMethodDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(RoutineDefinition node)
		{
			Visit((Declaration) node);
			traverse(node.header);
			traverse(node.body);
			return true;
		}
		
		public virtual bool Visit(CallableDirectives node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(RoutineDirectives node)
		{
			Visit((CallableDirectives) node);
			return true;
		}
		
		public virtual bool Visit(MethodDirectives node)
		{
			Visit((CallableDirectives) node);
			return true;
		}
		
		public virtual bool Visit(CompositeDeclaration node)
		{
			Visit((TypeDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(ClassBody node)
		{
			Visit((Section) node);
			traverse(node.fields);
			traverse(node.content);
			return true;
		}
		
		public virtual bool Visit(ClassDefinition node)
		{
			Visit((CompositeDeclaration) node);
			traverse(node.ClassBody);
			return true;
		}
		
		public virtual bool Visit(InterfaceDefinition node)
		{
			Visit((CompositeDeclaration) node);
			traverse(node.methods);
			traverse(node.properties);
			return true;
		}
		
		public virtual bool Visit(ClassContent node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(ClassMethod node)
		{
			Visit((ClassContent) node);
			traverse(node.decl);
			return true;
		}
		
		public virtual bool Visit(ClassProperty node)
		{
			Visit((ClassContent) node);
			traverse(node.type);
			traverse(node.index);
			traverse(node.specs);
			traverse(node.def);
			return true;
		}
		
		public virtual bool Visit(PropertyReadNode node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(PropertyWriteNode node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(PropertySpecifiers node)
		{
			Visit((Node) node);
			traverse(node.index);
			traverse(node.read);
			traverse(node.write);
			traverse(node.stored);
			traverse(node.def);
			traverse(node.impl);
			return true;
		}
		
		public virtual bool Visit(PropertySpecifier node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(PropertyDefault node)
		{
			Visit((PropertySpecifier) node);
			traverse(node.lit);
			return true;
		}
		
		public virtual bool Visit(PropertyImplements node)
		{
			Visit((PropertySpecifier) node);
			return true;
		}
		
		public virtual bool Visit(PropertyStored node)
		{
			Visit((PropertySpecifier) node);
			return true;
		}
		
		public virtual bool Visit(PropertyIndex node)
		{
			Visit((PropertySpecifier) node);
			return true;
		}
		
		public virtual bool Visit(Statement node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(LabelStatement node)
		{
			Visit((Statement) node);
			traverse(node.stmt);
			return true;
		}
		
		public virtual bool Visit(EmptyStatement node)
		{
			Visit((Statement) node);
			return true;
		}
		
		public virtual bool Visit(BreakStatement node)
		{
			Visit((Statement) node);
			return true;
		}
		
		public virtual bool Visit(ContinueStatement node)
		{
			Visit((Statement) node);
			return true;
		}
		
		public virtual bool Visit(Assignement node)
		{
			Visit((Statement) node);
			traverse(node.lvalue);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(GotoStatement node)
		{
			Visit((Statement) node);
			return true;
		}
		
		public virtual bool Visit(IfStatement node)
		{
			Visit((Statement) node);
			traverse(node.condition);
			traverse(node.thenblock);
			traverse(node.elseblock);
			return true;
		}
		
		public virtual bool Visit(ExpressionStatement node)
		{
			Visit((Statement) node);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(CaseSelector node)
		{
			Visit((Statement) node);
			traverse(node.list);
			traverse(node.stmt);
			return true;
		}
		
		public virtual bool Visit(CaseStatement node)
		{
			Visit((Statement) node);
			traverse(node.condition);
			traverse(node.selectors);
			traverse(node.caseelse);
			return true;
		}
		
		public virtual bool Visit(LoopStatement node)
		{
			Visit((Statement) node);
			traverse(node.condition);
			traverse(node.block);
			return true;
		}
		
		public virtual bool Visit(RepeatLoop node)
		{
			Visit((LoopStatement) node);
			return true;
		}
		
		public virtual bool Visit(WhileLoop node)
		{
			Visit((LoopStatement) node);
			return true;
		}
		
		public virtual bool Visit(ForLoop node)
		{
			Visit((LoopStatement) node);
			traverse(node.var);
			traverse(node.start);
			traverse(node.end);
			return true;
		}
		
		public virtual bool Visit(BlockStatement node)
		{
			Visit((Statement) node);
			traverse(node.stmts);
			return true;
		}
		
		public virtual bool Visit(WithStatement node)
		{
			traverse(node.with);
			traverse(node.body);
			return true;
		}
		
		public virtual bool Visit(TryFinallyStatement node)
		{
			Visit((Statement) node);
			traverse(node.body);
			traverse(node.final);
			return true;
		}
		
		public virtual bool Visit(TryExceptStatement node)
		{
			Visit((Statement) node);
			traverse(node.body);
			traverse(node.final);
			return true;
		}
		
		public virtual bool Visit(ExceptionBlock node)
		{
			Visit((Statement) node);
			traverse(node.onList);
			traverse(node.@default);
			return true;
		}
		
		public virtual bool Visit(RaiseStatement node)
		{
			Visit((Statement) node);
			traverse(node.lvalue);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(OnStatement node)
		{
			Visit((Statement) node);
			traverse(node.body);
			return true;
		}
		
		public virtual bool Visit(AssemblerBlock node)
		{
			Visit((BlockStatement) node);
			return true;
		}
		
		public virtual bool Visit(Expression node)
		{
			Visit((Node) node);
			traverse(node.Type);
			traverse(node.Value);
			traverse(node.ForcedType);
			return true;
		}
		
		public virtual bool Visit(EmptyExpression node)
		{
			Visit((Expression) node);
			return true;
		}
		
		public virtual bool Visit(ExpressionList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(ConstExpression node)
		{
			Visit((Expression) node);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(StructuredConstant node)
		{
			Visit((ConstExpression) node);
			return true;
		}
		
		public virtual bool Visit(ArrayConst node)
		{
			Visit((StructuredConstant) node);
			return true;
		}
		
		public virtual bool Visit(RecordConst node)
		{
			Visit((StructuredConstant) node);
			return true;
		}
		
		public virtual bool Visit(FieldInitList node)
		{
			Visit((ExpressionList) node);
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(FieldInit node)
		{
			Visit((ConstExpression) node);
			return true;
		}
		
		public virtual bool Visit(BinaryExpression node)
		{
			Visit((Expression) node);
			return true;
		}
		
		public virtual bool Visit(SetIn node)
		{
			Visit((BinaryExpression) node);
			traverse(node.expr);
			traverse(node.set);
			return true;
		}
		
		public virtual bool Visit(SetRange node)
		{
			Visit((BinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(ArithmethicBinaryExpression node)
		{
			Visit((BinaryExpression) node);
			traverse(node.left);
			traverse(node.right);
			return true;
		}
		
		public virtual bool Visit(Subtraction node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Addition node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Product node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Division node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Quotient node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Modulus node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(ShiftRight node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(ShiftLeft node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(LogicalBinaryExpression node)
		{
			Visit((BinaryExpression) node);
			traverse(node.left);
			traverse(node.right);
			return true;
		}
		
		public virtual bool Visit(LogicalAnd node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(LogicalOr node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(LogicalXor node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Equal node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(NotEqual node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(LessThan node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(LessOrEqual node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(GreaterThan node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(GreaterOrEqual node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(TypeBinaryExpression node)
		{
			Visit((BinaryExpression) node);
			traverse(node.expr);
			traverse(node.types);
			return true;
		}
		
		public virtual bool Visit(TypeIs node)
		{
			Visit((TypeBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(TypeCast node)
		{
			Visit((TypeBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(UnaryExpression node)
		{
			Visit((Expression) node);
			return true;
		}
		
		public virtual bool Visit(SimpleUnaryExpression node)
		{
			Visit((Expression) node);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(UnaryPlus node)
		{
			Visit((SimpleUnaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(UnaryMinus node)
		{
			Visit((SimpleUnaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(LogicalNot node)
		{
			Visit((SimpleUnaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(AddressLvalue node)
		{
			Visit((SimpleUnaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Set node)
		{
			Visit((UnaryExpression) node);
			traverse(node.setelems);
			return true;
		}
		
		public virtual bool Visit(ConstantValue node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(IntegralValue node)
		{
			Visit((ConstantValue) node);
			return true;
		}
		
		public virtual bool Visit(StringValue node)
		{
			Visit((ConstantValue) node);
			return true;
		}
		
		public virtual bool Visit(RealValue node)
		{
			Visit((ConstantValue) node);
			return true;
		}
		
		public virtual bool Visit(Literal node)
		{
			Visit((UnaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(OrdinalLiteral node)
		{
			Visit((Literal) node);
			return true;
		}
		
		public virtual bool Visit(IntLiteral node)
		{
			Visit((OrdinalLiteral) node);
			return true;
		}
		
		public virtual bool Visit(CharLiteral node)
		{
			Visit((OrdinalLiteral) node);
			return true;
		}
		
		public virtual bool Visit(BoolLiteral node)
		{
			Visit((OrdinalLiteral) node);
			return true;
		}
		
		public virtual bool Visit(StringLiteral node)
		{
			Visit((Literal) node);
			return true;
		}
		
		public virtual bool Visit(RealLiteral node)
		{
			Visit((Literal) node);
			return true;
		}
		
		public virtual bool Visit(PointerLiteral node)
		{
			Visit((Literal) node);
			return true;
		}
		
		public virtual bool Visit(LvalueExpression node)
		{
			Visit((UnaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(ArrayAccess node)
		{
			Visit((LvalueExpression) node);
			traverse(node.lvalue);
			traverse(node.acessors);
			traverse(node.array);
			return true;
		}
		
		public virtual bool Visit(PointerDereference node)
		{
			Visit((LvalueExpression) node);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(InheritedCall node)
		{
			Visit((LvalueExpression) node);
			traverse(node.call);
			return true;
		}
		
		public virtual bool Visit(RoutineCall node)
		{
			Visit((LvalueExpression) node);
			traverse(node.func);
			traverse(node.args);
			traverse(node.basictype);
			return true;
		}
		
		public virtual bool Visit(FieldAcess node)
		{
			Visit((LvalueExpression) node);
			traverse(node.obj);
			return true;
		}
		
		public virtual bool Visit(Identifier node)
		{
			Visit((LvalueExpression) node);
			return true;
		}
		
		public virtual bool Visit(TypeNode node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(UndefinedType node)
		{
			Visit((TypeNode) node);
			return true;
		}
		
		public virtual bool Visit(CompositeType node)
		{
			Visit((TypeNode) node);
			return true;
		}
		
		public virtual bool Visit(ClassType node)
		{
			Visit((CompositeType) node);
			return true;
		}
		
		public virtual bool Visit(InterfaceType node)
		{
			Visit((CompositeType) node);
			return true;
		}
		
		public virtual bool Visit(VariableType node)
		{
			Visit((TypeNode) node);
			return true;
		}
		
		public virtual bool Visit(MetaclassType node)
		{
			Visit((VariableType) node);
			traverse(node.baseType);
			return true;
		}
		
		public virtual bool Visit(TypeUnknown node)
		{
			Visit((TypeNode) node);
			return true;
		}
		
		public virtual bool Visit(EnumType node)
		{
			Visit((VariableType) node);
			traverse(node.enumVals);
			return true;
		}
		
		public virtual bool Visit(RangeType node)
		{
			Visit((VariableType) node);
			traverse(node.min);
			traverse(node.max);
			return true;
		}
		
		public virtual bool Visit(ScalarType node)
		{
			Visit((VariableType) node);
			return true;
		}
		
		public virtual bool Visit(ScalarTypeForward node)
		{
			Visit((ScalarType) node);
			return true;
		}
		
		public virtual bool Visit(StringType node)
		{
			Visit((ScalarType) node);
			return true;
		}
		
		public virtual bool Visit(FixedStringType node)
		{
			Visit((ScalarType) node);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(VariantType node)
		{
			Visit((ScalarType) node);
			traverse(node.actualtype);
			return true;
		}
		
		public virtual bool Visit(PointerType node)
		{
			Visit((ScalarType) node);
			traverse(node.pointedType);
			return true;
		}
		
		public virtual bool Visit(IntegralType node)
		{
			Visit((ScalarType) node);
			return true;
		}
		
		public virtual bool Visit(IntegerType node)
		{
			Visit((IntegralType) node);
			return true;
		}
		
		public virtual bool Visit(SignedIntegerType node)
		{
			Visit((IntegerType) node);
			return true;
		}
		
		public virtual bool Visit(UnsignedIntegerType node)
		{
			Visit((IntegerType) node);
			return true;
		}
		
		public virtual bool Visit(UnsignedInt8Type node)
		{
			Visit((UnsignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(UnsignedInt16Type node)
		{
			Visit((UnsignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(UnsignedInt32Type node)
		{
			Visit((UnsignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(UnsignedInt64Type node)
		{
			Visit((UnsignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(SignedInt8Type node)
		{
			Visit((SignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(SignedInt16Type node)
		{
			Visit((SignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(SignedInt32Type node)
		{
			Visit((SignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(SignedInt64Type node)
		{
			Visit((IntegerType) node);
			return true;
		}
		
		public virtual bool Visit(BoolType node)
		{
			Visit((IntegralType) node);
			return true;
		}
		
		public virtual bool Visit(CharType node)
		{
			Visit((IntegralType) node);
			return true;
		}
		
		public virtual bool Visit(RealType node)
		{
			Visit((ScalarType) node);
			return true;
		}
		
		public virtual bool Visit(FloatType node)
		{
			Visit((RealType) node);
			return true;
		}
		
		public virtual bool Visit(DoubleType node)
		{
			Visit((RealType) node);
			return true;
		}
		
		public virtual bool Visit(ExtendedType node)
		{
			Visit((RealType) node);
			return true;
		}
		
		public virtual bool Visit(CurrencyType node)
		{
			Visit((RealType) node);
			return true;
		}
		
		public virtual bool Visit(StructuredType node)
		{
			Visit((VariableType) node);
			traverse(node.basetype);
			return true;
		}
		
		public virtual bool Visit(ArrayType node)
		{
			Visit((StructuredType) node);
			return true;
		}
		
		public virtual bool Visit(SetType node)
		{
			Visit((StructuredType) node);
			return true;
		}
		
		public virtual bool Visit(FileType node)
		{
			Visit((StructuredType) node);
			return true;
		}
		
		public virtual bool Visit(RecordType node)
		{
			Visit((StructuredType) node);
			traverse(node.compTypes);
			return true;
		}
	}
}
