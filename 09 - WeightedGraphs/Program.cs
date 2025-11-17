int size = 25;

Maze maze = new Maze(size);

maze.AddEdge(0, 1);
maze.AddEdge(1, 2);
maze.AddEdge(2, 3);
maze.AddEdge(3, 4);
maze.AddEdge(4, 9);
maze.AddEdge(9, 14);
maze.AddEdge(18, 17);
maze.AddEdge(18, 19);
maze.AddEdge(19, 14);
maze.AddEdge(19, 24);
maze.AddEdge(24, 23);
maze.AddEdge(18, 23);
maze.AddEdge(22, 23);
maze.AddEdge(17, 12);
maze.AddEdge(21, 22);
maze.AddEdge(21, 20);
maze.AddEdge(20, 15);
maze.AddEdge(15, 10);
maze.AddEdge(10, 5);
maze.AddEdge(5, 0);

maze.Dijkstra(12);

ChickenMaze chickenmaze = new ChickenMaze(10);

chickenmaze.AddEdge(1, 5, 25);
chickenmaze.AddEdge(1, 2, 10);
chickenmaze.AddEdge(1, 3, 2);
chickenmaze.AddEdge(2, 3, 10);
chickenmaze.AddEdge(2, 4, 10);
chickenmaze.AddEdge(2, 6, 20);
chickenmaze.AddEdge(3, 5, 5);
chickenmaze.AddEdge(3, 4, 40);
chickenmaze.AddEdge(4, 5, 0);
chickenmaze.AddEdge(4, 7, 10);
chickenmaze.AddEdge(5, 8, 15);
chickenmaze.AddEdge(6, 7, 50);
chickenmaze.AddEdge(6, 9, 25);
chickenmaze.AddEdge(7, 8, 5);
chickenmaze.AddEdge(7, 9, 5);
chickenmaze.AddEdge(8, 9, 2);

chickenmaze.Dijkstra(1, 9);