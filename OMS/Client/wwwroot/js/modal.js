function loadJs() {
    const Add_btn = document.getElementById('add-intern');

    const Modal_edit = document.getElementsByClassName('btn-edt');
    const Modal_del = document.getElementsByClassName('btn-del');
    const Modal_cancel = document.getElementById('btn-can');
    const Close_add = document.getElementById('close-add');
    const Close_edit = document.getElementById('close-edit');



    Add_btn.addEventListener('click', function () {
        document.querySelector('.bg-modal').style.display = 'flex';
        document.getElementsByClassName('modal-content')[0].classList.add('show')
        document.getElementsByClassName('modal-edit')[0].classList.remove('show')
        document.getElementsByClassName('modal-delete')[0].classList.remove('show')

    })


    Close_add.addEventListener('click', function () {
        document.querySelector('.bg-modal').style.display = 'none';
    })


    Close_edit.addEventListener('click', function () {
        document.querySelector('.bg-modal').style.display = 'none';
    })


    for (i = 0; i < Modal_edit.length; i++) {
        Modal_edit[i].addEventListener('click', function () {
            document.querySelector('.bg-modal').style.display = 'flex';
            document.getElementsByClassName('modal-edit')[0].classList.add('show')
            document.getElementsByClassName('modal-delete')[0].classList.remove('show')
            document.getElementsByClassName('modal-content')[0].classList.remove('show')
        })
    }



    for (i = 0; i < Modal_del.length; i++) {
        Modal_del[i].addEventListener('click', function () {
            document.querySelector('.bg-modal').style.display = 'flex';
            document.getElementsByClassName('modal-delete')[0].classList.add('show')
            document.getElementsByClassName('modal-edit')[0].classList.remove('show')
            document.getElementsByClassName('modal-content')[0].classList.remove('show')
        })
    }


    Modal_cancel.addEventListener('click', function () {
        document.querySelector('.bg-modal').style.display = 'none';
    })
}

function loadNav() {
    const body = document.querySelector('body'),
        sidebar = body.querySelector('.sidebar'),
        toggle = body.querySelector('.toggle'),
        searchBar = body.querySelector('.search-bar'),
        modeSwitch = body.querySelector('.toggle-switch'),
        modeText = body.querySelector('.mode-text');


    toggle.addEventListener('click', () => {
        sidebar.classList.toggle('close');
    });

    modeSwitch.addEventListener('click', () => {
        body.classList.toggle('dark');

        if (body.classList.contains('dark')) {
            modeText.innerText = 'Light Mode'
        }
        else {
            modeText.innerText = 'Dark Mode'
        }
    });
}


