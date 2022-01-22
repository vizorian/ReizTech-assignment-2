using ReizTech_assignment_2;

// Creating the root
Branch root = new Branch();

// Creating layer 2
root.AddBranch();
root.AddBranch();

// Creating layer 3
root.branches[0].AddBranch();
root.branches[1].AddBranch();
root.branches[1].AddBranch();
root.branches[1].AddBranch();

// Creating layer 4
root.branches[1].branches[0].AddBranch();
root.branches[1].branches[1].AddBranch();
root.branches[1].branches[1].AddBranch();

//// Creating layer 5
root.branches[1].branches[1].branches[0].AddBranch();

Console.WriteLine($"Depth of the tree is {FindDepth(root)}");


/// <summary>
/// Function which recursively iterates through the tree and returns the largest depth
/// </summary>
static int FindDepth(Branch branch, int currentDepth = 1)
{
    var depth = currentDepth;

    foreach (Branch b in branch.branches)
    {
        // Recursion
        var newDepth = FindDepth(b, currentDepth + 1);
        if(newDepth > depth) { depth = newDepth; }
    }

    return depth;
}
