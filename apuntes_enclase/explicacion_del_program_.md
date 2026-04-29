Read [](file:///c%3A/Users/renzo/Desktop/prog2_2026/Proyecto-Recomendador/ProyectoRecomendador/Program.cs)

Aquí está la explicación por bloques:

**Bloque 1 - Usuarios (líneas 5-19):** Se crean dos objetos `Usuario` que representan a Ana y Renzo. Cada uno tiene un ID único, nombre, una lista de géneros musicales que prefieren y un historial de IDs de canciones que ya han escuchado. Estos datos son los que el sistema usará para personalizar las recomendaciones.

**Bloque 2 - Catálogo de Canciones (líneas 21-30):** Se define una lista de 6 canciones disponibles, cada una con un ID único, nombre, artista y atributos (géneros). Este catálogo es el que el algoritmo de recomendación analizará para encontrar coincidencias con las preferencias de cada usuario.

**Bloque 3 - Creación del Recomendador (línea 32):** Se instancia un nuevo objeto `Recomendador`, que contiene el algoritmo que calcula qué canciones recomendar basándose en las preferencias del usuario y su historial.

**Bloque 4 - Recomendaciones para Ana (líneas 34-41):** El sistema ejecuta el método `RecomendarPorPreferencias` pasando a Ana y el catálogo de canciones. El algoritmo filtra las canciones para devolver solo aquellas que coinciden con sus gustos (rock y pop) y que no ha escuchado. Luego imprime en consola cada canción recomendada con un guion.

**Bloque 5 - Recomendaciones para Renzo (líneas 43-51):** El mismo proceso se repite para Renzo. El sistema calcula sus recomendaciones buscando canciones que coincidan con sus preferencias (rap y grunge) y que no estén en su historial, imprimiendo los resultados en consola de forma similar a Ana.