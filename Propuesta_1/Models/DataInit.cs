using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Propuesta_1.Models
{
    public class DataInit
    {
        public List<BlogEntry> blogEntries { get; set; }

        public DataInit()
        {
            Init();
        }

        private void Init()
        {
            blogEntries = new List<BlogEntry>();

            blogEntries.Add(new BlogEntry {
                ID = 1,
                Autor = "Autor de Blog",
                Fecha = "Agosto 1, 2017",
                Tag = "Tag 1",
                Img = "500x281.png",
                Nombre = "¡Somos seguridad, garantía y confianza!",
                Contenido = "<p class='post-content'>Nulla facilisi. Integer lacinia sollicitudin massa. Cras metus. Sed aliquet risus a tortor. Integer id quam. Morbi mi. Quisque nisl felis, venenatis tristique, dignissim in, ultrices sit amet, augue. Proin sodales libero eget ante. Nulla quam. Aenean laoreet. Vestibulum nisi lectus, commodo ac, facilisis ac, ultricies eu, pede. Ut orci risus, accumsan porttitor, cursus quis, aliquet eget, justo.</p><p class='post-content'>Quisque cursus, metus vitae pharetra auctor, sem massa mattis sem, at interdum magna augue eget diam.Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Morbi lacinia molestie dui.Praesent blandit dolor. Sed non quam.In vel mi sit amet augue congue elementum. Morbi in ipsum sit amet pede facilisis laoreet. Donec lacus nunc, viverra nec, blandit vel, egestas et, augue.Vestibulum tincidunt malesuada tellus. Ut ultrices ultrices enim. Curabitur sit amet mauris. Morbi in dui quis est pulvinar ullamcorper.</p><p class='post-content'>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.Nam nec ante. Sed lacinia, urna non tincidunt mattis, tortor neque adipiscing diam, a cursus ipsum ante quis turpis. Nulla facilisi. Ut fringilla. Suspendisse potenti. Nunc feugiat mi a tellus consequat imperdiet.Vestibulum sapien. Proin quam. Etiam ultrices. Suspendisse in justo eu magna luctus suscipit.Sed lectus. Integer euismod lacus luctus magna. </p>"
            });

            blogEntries.Add(new BlogEntry
            {
                ID = 2,
                Autor = "Autor de Blog",
                Fecha = "Julio 24, 2017",
                Tag = "Tag 2",
                Img = "500x281.png",
                Nombre = "La Falta de Educación",
                Contenido = "<p class='post-content'>Nulla facilisi. Integer lacinia sollicitudin massa. Cras metus. Sed aliquet risus a tortor. Integer id quam. Morbi mi. Quisque nisl felis, venenatis tristique, dignissim in, ultrices sit amet, augue. Proin sodales libero eget ante. Nulla quam. Aenean laoreet. Vestibulum nisi lectus, commodo ac, facilisis ac, ultricies eu, pede. Ut orci risus, accumsan porttitor, cursus quis, aliquet eget, justo.</p><p class='post-content'>Quisque cursus, metus vitae pharetra auctor, sem massa mattis sem, at interdum magna augue eget diam.Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Morbi lacinia molestie dui.Praesent blandit dolor. Sed non quam.In vel mi sit amet augue congue elementum. Morbi in ipsum sit amet pede facilisis laoreet. Donec lacus nunc, viverra nec, blandit vel, egestas et, augue.Vestibulum tincidunt malesuada tellus. Ut ultrices ultrices enim. Curabitur sit amet mauris. Morbi in dui quis est pulvinar ullamcorper.</p><p class='post-content'>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.Nam nec ante. Sed lacinia, urna non tincidunt mattis, tortor neque adipiscing diam, a cursus ipsum ante quis turpis. Nulla facilisi. Ut fringilla. Suspendisse potenti. Nunc feugiat mi a tellus consequat imperdiet.Vestibulum sapien. Proin quam. Etiam ultrices. Suspendisse in justo eu magna luctus suscipit.Sed lectus. Integer euismod lacus luctus magna. </p>"
            });

            blogEntries.Add(new BlogEntry
            {
                ID = 3,
                Autor = "Autor de Blog",
                Fecha = "Julio 24, 2017",
                Tag = "Tag 1",
                Img = "500x281.png",
                Nombre = "Creación de Espacios",
                Contenido = "<p class='post-content'>Nulla facilisi. Integer lacinia sollicitudin massa. Cras metus. Sed aliquet risus a tortor. Integer id quam. Morbi mi. Quisque nisl felis, venenatis tristique, dignissim in, ultrices sit amet, augue. Proin sodales libero eget ante. Nulla quam. Aenean laoreet. Vestibulum nisi lectus, commodo ac, facilisis ac, ultricies eu, pede. Ut orci risus, accumsan porttitor, cursus quis, aliquet eget, justo.</p><p class='post-content'>Quisque cursus, metus vitae pharetra auctor, sem massa mattis sem, at interdum magna augue eget diam.Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Morbi lacinia molestie dui.Praesent blandit dolor. Sed non quam.In vel mi sit amet augue congue elementum. Morbi in ipsum sit amet pede facilisis laoreet. Donec lacus nunc, viverra nec, blandit vel, egestas et, augue.Vestibulum tincidunt malesuada tellus. Ut ultrices ultrices enim. Curabitur sit amet mauris. Morbi in dui quis est pulvinar ullamcorper.</p><p class='post-content'>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.Nam nec ante. Sed lacinia, urna non tincidunt mattis, tortor neque adipiscing diam, a cursus ipsum ante quis turpis. Nulla facilisi. Ut fringilla. Suspendisse potenti. Nunc feugiat mi a tellus consequat imperdiet.Vestibulum sapien. Proin quam. Etiam ultrices. Suspendisse in justo eu magna luctus suscipit.Sed lectus. Integer euismod lacus luctus magna. </p>"
            });
        }
    }
}