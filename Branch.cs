namespace ReizTech_assignment_2
{
    class Branch
    {
        public List<Branch> branches;

        public Branch()
        {
            branches = new List<Branch>();
        }

        public void AddBranch()
        {
            branches.Add(new Branch());
        }
    }
}
