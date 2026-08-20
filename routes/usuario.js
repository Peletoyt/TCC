//CRUD do usuario.html
const express = require("express"); 
const router = express.Router();
const multer = require("multer");
const prisma = require("../prismaClient");
const admin = require('../middleware/admin');

// ─── Configuração de fotos ─────────────────────────────────────────────
const storage = multer.diskStorage({
    destination: (req, file, cb) => {
        cb(null, "public/uploads/");
    },
    filename: (req, file, cb) => {
        const nomeArquivo = `foto-${Date.now()}.jpg`;
        cb(null, nomeArquivo);
    }
});
const upload = multer({ storage: storage }); // Configura o destino dos arquivos enviados

// ─── READ: Buscar todos os usuários ───────────────────────────────────────────
router.get("/", admin, async (req, res) => {
    try{
        const usuarios = await prisma.usuario.findMany({
            orderBy: {
                idusuario: "desc"
            }
        });
        res.json(usuarios);
    } 
    catch (error) { console.error("Erro ao buscar usuários:", error);
        res.status(500).json({ error: "Ocorreu um erro ao buscar os usuários."
        });
    }
});

// ─── CREATE: Criar novo usuário ────────────────────────────────────────────────
router.post("/", admin, upload.single('foto'), async (req, res) => {
    const { nome, email, usuariocol } = req.body;
    
    try {
        if (!req.file) {
            return res.status(400).json({ error: "Nenhuma imagem enviada." });
        }

        const novoUsuario = await prisma.usuario.create({
            data: {
                nome,
                email,
                usuariocol,
                foto: req.file.filename
            }
        });
        res.status(201).json(novoUsuario);
    } catch (error) {
        console.error("Erro ao criar usuário:", error);
        res.status(500).json({ error: "Ocorreu um erro ao criar o usuário." });
    }
});

// ─── UPDATE: Atualizar usuário ────────────────────────────────────────────────

// ─── DELETE: Deletar usuário ────────────────────────────────────────────────


module.exports = router;