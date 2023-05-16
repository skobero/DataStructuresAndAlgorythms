namespace DataStructures.Helpers
{
    public class WeightedAdjacencyMatrix
    {
        private int[][] matrix;

        public WeightedAdjacencyMatrix(int[][] matrix)
        {
            this.matrix = matrix;
        }

        public int Length { 
            get
            {
                return matrix.Length;
            }
        }

        public int[] this[int x]
        {
            get
            {
                return this.matrix[x];
            }
        }
    }

    public class WeightedAdjacencyList
    {
        private GraphEdge[][] matrix;

        public WeightedAdjacencyList(GraphEdge[][] matrix)
        {
            this.matrix = matrix;
        }

        public int Length
        {
            get
            {
                return matrix.Length;
            }
        }

        public GraphEdge[] this[int x]
        {
            get
            {
                return this.matrix[x];
            }
        }
    }

    public class GraphEdge
    {
        public int from;
        public int to;
        public int weight;
    }
}