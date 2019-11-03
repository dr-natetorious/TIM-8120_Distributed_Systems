# Shortest Path Algorithms

## Dijkstra's algorithm

The key objective of this algorithm is to calculate the shortest distance from a starting point, to every other vertex in a graph. 

The strategy [attempts to build a table](https://www.youtube.com/watch?v=pVfj6mxhdMw) that specifies the distance to each vertex and its previous vertex. Then the shortest path can be determined by looking at the previous vertex column and walking back to the starting point.

At each iteration of the process, the _unvisited vertex with the shortest distance in the table_, is selected and then its edges are traversed in ascending order. As each edge is enumerated the `distince = starting_point + edge_weight` is compared against the current cost to reach that locaiton. If it is less, then the table is updated to signify a better route.

```c#
var shortest_path_table = Table<VertexId, Distance, PreviousVertex>
var visited, unvisited = list

// Init
foreach (vertex) {
    shortest_path_table.Add(vertex, infinity, null);
    unvisited.Add(vertex)
}

// Tag the starting point
shortest_path_table[start_point].distance = 0

// Loop until every node is visited
do
{
    var vertex = pop_shortest_distance_from_unvisited()
    foreach (edge in vertex.edges ordered desc) {
        var path_distance = vertex.distance + edge.weight
        var other_dude = shortest_path_table[edge.OtherEnd];

        if (other_dude in visited) continue

        if (other_dude.distance > path_distance) {
            other_dude = (path_distance, vertex);
        }
    }

    visited.Add(vertex)
} while(unvisited not empty)

```

![dijkstra.png](dijkstra.png)

## Bellman–Ford algorithm

The critical enhancement of Bellman-Ford is [the ability to tolerate negative edge weights](https://www.youtube.com/watch?v=9PHkk0UavIM). However, it does not support negative cycles. If a negative cycle exists, then the shortest path cannot be solved, as performing another loop is even smaller value.

BF is able to handle negative weights by not being a greedy algorithm, and enumerating |V|-1 times and updating the minimum distance of all nodes.

![bellman-ford.png](bellman-ford.png)

## A* search algorithm

Another challenge with Dijkstra's algo is the calculation of the current shortest path, even if [the step doesn't improve our goal](https://www.youtube.com/watch?v=ySN5Wnu88nE).

![dijkstra_problem.png](dijkstra_problem.png)

A* enhances the previous algorithms to include a heuristic of how far do we need to go. An example heuristic could be the `euclidian distance` from the vertex to the destination. Then `distance = start_point + edge_weight + heuristic`, which naturally forces a preference towards the lowest heuristic (and correct direction).

The strategy also leverages a priority queue that is sorted on the current shortest path. At the end of each iteration, the `first(priority_queue)` vertex is always chosen, until the end is reached or all vertexes are visited (no solution).

Since this strategy does not evaluate most of the vertexes, it has a much lower memory footprint and computational overhead.

## Floyd–Warshall algorithm

Dijkstr'a algorithm finds the shortest path from a _single node_, versus Floyd-Warshall finds [for _all vertice pairs_](https://www.youtube.com/watch?v=4OQeCuLYj-4). It also supports negative weights, similar to Bellman-Ford.

![floyd_warshall_pseudo.png](floyd_warshall_pseudo.png)

![floyd_warshall_solved.png](floyd_warshall_solved.png)

## Johnson's algorithm

https://www.youtube.com/watch?v=xc2ua8sQAoE

## Viterbi algorithm

https://www.youtube.com/watch?v=6JVqutwtzmo
