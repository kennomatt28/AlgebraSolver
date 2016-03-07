Public Class Form1
    Dim currequation As String=""
    dim variables as new arraylist
    Public Sub Suggest()
        Console.Writeline("What is your equation")
        currequation=Console.Readline()
        Console.Writeline("Enter for which variables (letters) you want to be solved with commas seperating each one")
        variables.addrange(Console.Readline.Split(","))
        dim solver as new Solver
        solver.solve(currequation)
    End Sub
    Private Sub Form1_Load(Byval sender As Object, Byval e as eventargs) handles base.load
        Suggest()
        Console.Read()
        
    End sub
End Class
Public Class Solver
    const letters() as string={'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'}
    const operators() as string={'/','*','-','+')
    dim lett as string
    dim ops as string
    
    Public sub Solve(Byval equation as string, byval variables as arraylist)
        dim c() as string=equation.tochararray()
        for each v as string in variables
            if c.contains(v)=false then
                variables.remove(v)
            end if
        end for
        dim rhs as string=equation.substring(instr("=")+1)
        dim lhs as string=equation.substring(0,instr("=")
        dim currvar as variable
        if lhs.length=1 then
            for each v as string in variables()
                if  lhs.contains(v)=true then
                    for each ch as char 
                end if
            end for
        end if
    end sub
End Class
