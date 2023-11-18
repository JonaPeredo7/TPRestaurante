document.addEventListener('DOMContentLoaded', function () {
    const filtroCategoria = document.getElementById('categoria');
    const menuItems = document.querySelectorAll('.menu-item');

    filtroCategoria.addEventListener('change', function () {
        const categoriaSeleccionada = filtroCategoria.value;

        menuItems.forEach(function (item) {
            const categoriaItem = item.getAttribute('data-categoria');

            if (categoriaSeleccionada === 'todas' || categoriaSeleccionada === categoriaItem) {
                item.style.display = 'block';
            } else {
                item.style.display = 'none';
            }
        });
    });
});
